using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IBookingService 
    {
        Task CreateBookingAsync(Booking booking);
        Task DeleteBookingAsync(int id);
        Task<IEnumerable<Booking>> GetBookingListAsync();
        Task<Booking> GetBookingByIdAsync(int id);
        Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id);
        Task UpdateBookingAsync(int id);
    }
}
