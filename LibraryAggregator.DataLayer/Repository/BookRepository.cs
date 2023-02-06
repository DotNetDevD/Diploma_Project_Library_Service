using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDataBaseContext _db) : base(_db)
        {
        }
        public async Task<Book> GetAllFullInfoBookAsync(int id)
        {
            return await dbSet.Include(u => u.BooksGenres)
                .ThenInclude(bl => bl.Genre)
                .Include(u => u.AuthorsBooks)
                .ThenInclude(u => u.Author)
                .FirstOrDefaultAsync(b => b.BookId == id);
        }
        public async Task<List<Book>> GetAllFullInfoBooksAsync()
        {
            return await dbSet.Include(u => u.BooksGenres)
                .ThenInclude(bl => bl.Genre)
                .Include(u => u.AuthorsBooks)
                .ThenInclude(u => u.Author)
                .ToListAsync();
        }
    }
}