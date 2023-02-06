using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IBookService
    {
        Task CreateBookAsync(Book book);
        Task DeleteBookAsync(int id);
        Task<IEnumerable<Book>> GetBooksListAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task UpdateBookAsync(int id);

        
    }
}