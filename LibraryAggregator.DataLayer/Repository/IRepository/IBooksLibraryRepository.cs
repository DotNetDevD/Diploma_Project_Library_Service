using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBooksLibraryRepository : IRepository<BooksLibrary>
    {
        Task<IEnumerable<BooksLibrary>> GetdLibraryListByBookIdAsync(int id);
        Task<BooksLibrary> GetFullBookLibraryInfoById(int id);
    }
}
