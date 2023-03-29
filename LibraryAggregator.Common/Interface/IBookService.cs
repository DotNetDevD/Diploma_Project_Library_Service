using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;

namespace LibraryAggregator.Common.Interface
{
    public interface IBookService
    {
        Task CreateBookAsync(Book book);
        Task DeleteBookAsync(int id);
        Task<IEnumerable<Book>> GetBooksListAsync();
        Task<IEnumerable<Book>> GetBooksListByGenreAsync(int genreId);
        Task<IEnumerable<Book>> GetBookListByAuthorIdAsync(int authorId);
        Task<IEnumerable<Book>> GetBookListByLibraryIdAsync(int libraryId);
        Task<Book> GetBookByIdAsync(int id);
        Task UpdateBookAsync(int id);
        
    }
}
