using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BookRepository : BaseRepository<Book>
    {
        //нужно ли наследование?
        public BookRepository(): base()
        {
        }
        public async Task<List<Book>> GetAllFullInfoBooksAsync()
        {
            return await dbSet.Include(u => u.BooksGenres).Include(u => u.BooksLibraries).Include(u => u.AuthorsBooks).ToListAsync();
        }
    }
}
