using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Interface
{
    public interface IBookingService
    {
        Task CreateBookingAsync(BookingDto bookingDto);
        Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id);
        Task<BooksLibrary> GetFullBookLibraryInfoById(int id);
        Task UpdateBookingAsync(int id, BookingStatuses bookingStatuses);
    }
}
