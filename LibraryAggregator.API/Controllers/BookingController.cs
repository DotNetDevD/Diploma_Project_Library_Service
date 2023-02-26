using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class BookingController : ApiBaseController
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("book/{id}")]
        public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
        {
            return await _bookingService.GetAvailableBookingByBookIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(BookingDto bookingDto)
        {
            await _bookingService.CreateBookingAsync(bookingDto);
        }
    }
}
