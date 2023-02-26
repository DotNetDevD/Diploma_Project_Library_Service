using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IBookingService 
    {
        Task CreateBookingAsync(BookingDto bookingDto);
        Task<Booking> GetBookingByIdAsync(int id);
        Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id);
    }
}
