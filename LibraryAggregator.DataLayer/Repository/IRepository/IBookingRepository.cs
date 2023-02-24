using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBookingRepository : IRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetFullInfoBookingsAsync();
        Task<Booking> GetFullInfoBookingAsync(int id);
    }
}
