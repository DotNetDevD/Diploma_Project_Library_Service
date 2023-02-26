using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities.Enum;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class StateService : IStateService 
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBookingService _bookingService;

        public StateService(IBookingRepository bookingRepository , IBookingService bookingService)
        {
            _bookingRepository = bookingRepository;
            _bookingService = bookingService;
        }

        public async Task BookingAsync(int id, BookingStatuses bookingStatus)
        {
            if (bookingStatus == BookingStatuses.Free)
                await _bookingService.UpdateBookingAsync(id, BookingStatuses.Booked);
        }

        public async Task CancellAsync(int id, BookingStatuses bookingStatus)
        {
            if (bookingStatus == BookingStatuses.Booked)
                await _bookingService.UpdateBookingAsync(id, BookingStatuses.Free);
            else if (bookingStatus == BookingStatuses.GivenClient)
                await _bookingService.UpdateBookingAsync(id, BookingStatuses.Free);
        }
        public Task FreeAsync(int id, BookingStatuses bookingStatus) // реализация 
        {
            throw new NotImplementedException();
        }

        public async Task GivenToTheClientAsync(int id, BookingStatuses bookingStatus)
        {
            if (bookingStatus == BookingStatuses.Booked)
                await _bookingService.UpdateBookingAsync(id, BookingStatuses.GivenClient);
        }

        public async Task ReturnedClientAsync(int id, BookingStatuses bookingStatus)
        {
            if (bookingStatus == BookingStatuses.GivenClient)
                await _bookingService.UpdateBookingAsync(id, BookingStatuses.Free);
        }

    }
}
