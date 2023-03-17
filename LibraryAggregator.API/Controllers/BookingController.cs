using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class BookingController : ApiBaseController
    {
        private readonly IBookingService _bookingService;
       
        public BookingController(IBookingService bookingService, IStateService stateService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("bookLibrary/{id}")]
        public async Task<BooksLibrary> GetFullBookLibraryInfoById(int id)
        {
            return await _bookingService.GetFullBookLibraryInfoById(id);
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
