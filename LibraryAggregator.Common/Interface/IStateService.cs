using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Interface
{
    public interface IStateService
    {
        Task BookingAsync(int id, BookingStatuses bookingStatus);
        Task CancellAsync(int id, BookingStatuses bookingStatus);
        Task FreeAsync(int id, BookingStatuses bookingStatus);
        Task GivenToTheClientAsync(int id, BookingStatuses bookingStatus);
        Task ReturnedClientAsync(int id, BookingStatuses bookingStatus);
    }
}
