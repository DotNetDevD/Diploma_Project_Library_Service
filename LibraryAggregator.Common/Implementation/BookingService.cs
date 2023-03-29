using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Implementation
{
  public class BookingService : IBookingService
  {
    private readonly IBookingRepository _bookingRepository;
    private readonly IBooksLibraryRepository _booksLibraryRepository;
    private readonly IClientRepository _clientRepository;

    public BookingService(IBookingRepository bookingRepository, IBooksLibraryRepository booksLibraryRepository,
        IClientRepository clientRepository)
    {
      _bookingRepository = bookingRepository;
      _booksLibraryRepository = booksLibraryRepository;
      _clientRepository = clientRepository;
    }

    public async Task CreateBookingAsync(BookingDto bookingDto)
    {
      await CreateClient(bookingDto);

      Booking booking = new()
      {
        Code = new Random().Next(10000),
        StartDate = DateTime.Now,
        FinishDate = DateTime.Now.AddDays(14),
        BooksLibraryId = bookingDto.BookLibraryId,
        ClientId = await _clientRepository.GetClientIdByEmailAsync(bookingDto.Email),
        BookingStatus = BookingStatuses.Booked
      };
      
      await _bookingRepository.CreateAsync(booking);
    }

    private async Task CreateClient(BookingDto bookingDto)
    {
      Client client = new()
      {
        Name = bookingDto.Name,
        Surname = bookingDto.Surname,
        PhoneNumber = bookingDto.PhoneNumber,
        Email = bookingDto.Email
      };
      await _clientRepository.CreateAsync(client);
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

    public async Task<Booking> GetBookingByIdAsync(int id)
    {
      return await _bookingRepository.GetFullInfoBookingAsync(id);
    }

    public async Task<BooksLibrary> GetFullBookLibraryInfoById(int id)
    {
      return await _booksLibraryRepository.GetFullBookLibraryInfoById(id);
    }

    public async Task UpdateBookingAsync(int id, BookingStatuses bookingStatuses)
    {
      Booking booking = await GetBookingByIdAsync(id);
      booking.BookingStatus = bookingStatuses;
      await _bookingRepository.UpdateAsync(id);
    }

    public async Task<IEnumerable<Booking>> GetBooks()
    {
      return  await _bookingRepository.GetFullBookingBooks();
    }

  }
}
