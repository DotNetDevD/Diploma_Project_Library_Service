using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BooksLibraryRepository : BaseRepository<BooksLibrary>, IBooksLibraryRepository
    {
        public BooksLibraryRepository(LibraryDataBaseContext libraryDataBaseContext) : base(libraryDataBaseContext)
        {
        }

        public async Task<IEnumerable<BooksLibrary>> GetdLibraryListByBookIdAsync(int id)
        {
            return await dbSet.Include(u => u.Book)
                    .ThenInclude(a => a.AuthorsBooks).ThenInclude(a => a.Author)
                    .Include(u => u.Booking).ThenInclude(u => u.Client)
                    .Include(u => u.Booking).ThenInclude(u => u.BookingStatus)
                    .Include(l => l.Library)
                    .Where(b => b.BookId == id).ToListAsync();
        }

        public async Task<BooksLibrary> GetFullBookLibraryInfoById(int id)
        {
            return await dbSet.Include(u => u.Book)
                   .ThenInclude(a => a.AuthorsBooks).ThenInclude(a => a.Author)
                   .Include(l => l.Library)
                   .FirstOrDefaultAsync(i => i.BooksLibrariesId == id);
        }
    }
}
