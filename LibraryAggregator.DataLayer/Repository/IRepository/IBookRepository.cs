using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetFullInfoBookAsync(int id);
        Task<IEnumerable<Book>> GetFullInfoBooksAsync();
    }
}
