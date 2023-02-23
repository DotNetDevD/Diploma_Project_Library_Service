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
        public async Task<Book> GetFullInfoBookAsync(int id)
        {
            return await dbSet.Include(u => u.BooksGenres)
                    .ThenInclude(bl => bl.Genre)
                    .Include(u => u.AuthorsBooks)
                    .ThenInclude(u => u.Author)
                    .Include(l => l.BooksLibraries)
                    .FirstOrDefaultAsync(b => b.BookId == id);
        }

        public async Task<IEnumerable<Book>> GetFullInfoBooksAsync()
        {
            return await dbSet.Include(u => u.BooksGenres)
                    .ThenInclude(bl => bl.Genre)
                    .Include(u => u.AuthorsBooks)
                    .ThenInclude(u => u.Author)
                    .Include(l => l.BooksLibraries)
                    .ToListAsync();
        }

        public async Task<IEnumerable<Book>> SearchTermByUserInput(string title)
        {
            return await dbSet.Include(u => u.BooksGenres)
                    .ThenInclude(bl => bl.Genre)
                    .Include(u => u.AuthorsBooks)
                    .ThenInclude(u => u.Author)
                    .Include(l => l.BooksLibraries)
                    .Where(b => b.Title.Contains(title))
                    .ToListAsync();
        }
    }
}