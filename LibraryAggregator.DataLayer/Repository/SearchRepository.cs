using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class SearchRepository : BaseRepository<Book>, ISearchRepository
    {
        public SearchRepository(LibraryDataBaseContext libraryDataBaseContext) : base(libraryDataBaseContext)
        {

        }

        public async Task<IEnumerable<Book>> GetListBooksAsync(string title)
        {
             return await dbSet.Include(u => u.BooksGenres)
                .ThenInclude(bl => bl.Genre)
                .Include(u => u.AuthorsBooks)
                .ThenInclude(u => u.Author)
                .Where(item => item.Title.Contains(title))
                .ToListAsync();
        }
    }
}
