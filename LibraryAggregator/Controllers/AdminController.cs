using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.AdminAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdminController : Controller
  {
    private readonly IAdminService _adminService;
    private readonly IBookingService _bookingService;

    public AdminController(IAdminService adminService, IBookingService bookingService)
    {
      _adminService = adminService;
      _bookingService = bookingService;
    }
    [Authorize]
    [HttpGet("{id}")]
    public async Task<Admin> GetAdmin(int id)
    {
      return await _adminService.GetAdminById(id);
    }
    [HttpPost("refresh")]
    public async Task<TokenDto> RefreshToken(TokenDto tokenDto)
    {
      return await _adminService.Refresh(tokenDto);
    }

    [HttpGet("Library")]
    public async Task<IEnumerable<LibraryDto>> GetLibrary(int id)
    {
      return await _adminService.GetListBooks(id);
    }

    [HttpGet("BooksBooking")]
    public async Task<IEnumerable<Booking>> getBooksBooking()
    {
      return await _bookingService.GetBooks();
    }

    [HttpPost("booking")]
    public async Task AddBooking(BookingDto bookingDto)
    {
      await _bookingService.CreateBookingAsync(bookingDto);
    }

    [HttpDelete("delete{id}")]

    public async Task DeleteBooking(int id)
    {
      await _bookingService.DeleteRecord(id);
    }
  }
}
