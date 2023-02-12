using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface ISearchRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetListBooksAsync(string title);
    }
}
