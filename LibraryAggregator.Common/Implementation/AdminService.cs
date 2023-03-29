using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Helpers;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using LibraryAggregator.DataLayer.Repository;
using LibraryAggregator.DataLayer.Repository.IRepository;


namespace LibraryAggregator.Common.Implementation;

public class AdminService : IAdminService
{
  private readonly IAdminRepository _adminRepository;
  private readonly ILibraryRepository _libraryRepository;
  private readonly IBookingRepository _bookingRepository;
  private readonly IBooksLibraryRepository _booksLibraryRepository;

  public AdminService(IAdminRepository adminRepository,
                      ILibraryRepository libraryRepository,
                      IBooksLibraryRepository booksLibraryRepository,
                      IBookingRepository bookingRepository )
  {
    _adminRepository = adminRepository;
    _libraryRepository = libraryRepository;
    _booksLibraryRepository = booksLibraryRepository;
    _bookingRepository = bookingRepository;
  }

  public async Task<TokenDto> AdminAuth(RequestData request)
  {
    request.Password = PasswordHasher.HashPassword(request.Password);
    var admin = await _adminRepository.GetAdmin(request);
    if (admin is null)
    {
      throw new Exception(nameof(AdminEnum.NoAdmin));

    }
    admin.Token = new JwtToken().CreateToken(admin);
    TokenDto tokenDto = await new JwtToken().GetTokens(admin);
    _adminRepository.SaveChanges();
    return tokenDto;
  }

  public async Task<Admin> GetAdminById(int id)
  {
    return await _adminRepository.GetAdminById(id);
  }
  public async Task<string> NewRefreshToken()
  {
    var jwt = new JwtToken().CreateRefreshToken();
    var cheakToken = await _adminRepository.RefreshToken(jwt);
    if (cheakToken)
    {
      await NewRefreshToken();
    }
    return jwt;
  }

  public async Task<TokenDto> Refresh(TokenDto tokenDto)
  {
    if (tokenDto is null)
      throw new Exception("Invalid Request");
    string accessToken = tokenDto.AccessToken;
    string refreshToken = tokenDto.RefreshToken;
    var principal = new JwtToken().GetPrincipaleFromExpiredToken(accessToken);
    var adminName = principal.Identity.Name;
    var admin = await _adminRepository.GetAdminByAdminName(adminName);
    if (admin is null || admin.RefreshToken != refreshToken || admin.RefreshTokenExpireTime <= DateTime.Now)
      throw new Exception("Invalid Request");
    JwtToken jwtToken = new JwtToken();
    var newAccessToken = jwtToken.CreateToken(admin);
    admin.RefreshToken = jwtToken.CreateRefreshToken();
    _adminRepository.SaveChanges();
    return new TokenDto
    {
      AccessToken = admin.RefreshToken,
      RefreshToken = newAccessToken
    };
  }

  public async Task<IEnumerable<LibraryDto>> GetListBooks(int id)
  {
    List<LibraryDto> ListLibrary = new List<LibraryDto>();
    var booksInlibrary = await _libraryRepository.GetCurrentBooksInLibrary(id);
   foreach (var item in booksInlibrary.BooksLibraries)
    {
      ListLibrary.Add(new LibraryDto
      {
        Id = item.BookId,
        Title = item.Book.Title,
        Count = item.Count,
        Status = nameof(BookingStatuses.Free),
        booksLibrariesId = item.BooksLibrariesId,
        Booked = item.Booking.Where(b => b.BookingStatus == BookingStatuses.Booked).Count(),
        FreeBook = item.Count - item.Booking.Where(b => b.BookingStatus == BookingStatuses.Booked).Count(),
        isFreeBook = item.IsFreeBook
      }
      ); 
      
    }
    return ListLibrary;
   
  }

  public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
  {
    IEnumerable<BooksLibrary> booksLibraries = await _booksLibraryRepository.GetdLibraryListByBookIdAsync(id);
    foreach (BooksLibrary book in booksLibraries)
    {
      book.BookedBook = book.Booking.Where(b => b.BookingStatus == BookingStatuses.Booked).Count();
      book.FreeBook = book.Count - book.BookedBook;
      if (book.FreeBook > 0)
        book.IsFreeBook = false;
    }
    return booksLibraries;
  }

  public async Task DeleteRecord(int id)
  {
    await _bookingRepository.DeleteRecord(id);
  }
}

