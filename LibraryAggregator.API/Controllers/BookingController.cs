using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class BookingController : ApiBaseController
    {
        private readonly IBookingService _bookingService;
        private readonly IStateService _stateService;

        public BookingController(IBookingService bookingService, IStateService stateService)
        {
            _bookingService = bookingService;
            _stateService = stateService;
        }

        [HttpGet(Name = "BookingList")]
        public async Task<IEnumerable<Booking>> GetListAsync()
        {
            return await _bookingService.GetBookingListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Booking> GetByIdAsync(int id)
        {
            return await _bookingService.GetBookingByIdAsync(id);
        }

        [HttpGet("book/{id}")]
        public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
        {
            return await _bookingService.GetAvailableBookingByBookIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Booking booking)
        {
            await _bookingService.CreateBookingAsync(booking);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _bookingService.DeleteBookingAsync(id);
        }

        [HttpPut]
        public async Task UpdateBookingStatusAsync(int id , BookingStatuses bookingStatus)
        {
            await _bookingService.UpdateBookingAsync(id , bookingStatus);
        }

        [HttpPut("booking/{bookingStatus}")]
        public async Task ChangeStatusBooking(int id, BookingStatuses bookingStatus)
        {
            await _stateService.BookingAsync(id, bookingStatus);
        }

        [HttpPut("returnedclient/{bookingStatus}")]
        public async Task ChangeStatusReturnedClient(int id, BookingStatuses bookingStatus)
        {
            await _stateService.ReturnedClientAsync(id, bookingStatus);
        }

        [HttpPut("giventotheclient/{bookingStatus}")]
        public async Task ChangeStatusGivenToTheClient(int id, BookingStatuses bookingStatus)
        {
            await _stateService.GivenToTheClientAsync(id, bookingStatus);
        }

        [HttpPut("cancell/{bookingStatus}")]
        public async Task ChangeStatusCancell(int id, BookingStatuses bookingStatus)
        {
            await _stateService.CancellAsync(id, bookingStatus);
        }

    }
}
