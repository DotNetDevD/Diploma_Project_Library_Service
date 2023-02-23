using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBookingRepository : IRepository<Booking>, IGenericSearchRepository<Author>
    {
        Task<IEnumerable<Author>> GetFullInfoAuthorsAsync();
        Task<Author> GetFullInfoAuthorAsync(int id);
    }
}
