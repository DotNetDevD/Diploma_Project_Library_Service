using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository , IGenericSearchRepository<Library>
    {
        public LibraryRepository(LibraryDataBaseContext db) : base( db)
        {
        }
        public async Task<IEnumerable<Library>> GetFullInfoLibrariesAsync()
        {
            return await dbSet.Include(item => item.BooksLibraries)
                              .ThenInclude(item => item.Book)
                              .Include(item => item.ImagesForCarousel)
                              .Include(item => item.OperatingModes)
                              .ToListAsync();
        }

        public async Task<Library> GetFullInfoLibraryAsync(int id)
        {
            return await dbSet.Include(item => item.BooksLibraries)
                              .ThenInclude(item => item.Book)
                              .Include(item => item.ImagesForCarousel)
                              .Include(item => item.OperatingModes)
                              .FirstOrDefaultAsync(item => item.LibraryId == id);
        }

        public async Task<IEnumerable<Library>> SearchSomeEntityByTitle(string title)
        {
            return await dbSet.Include(item => item.BooksLibraries)
                                 .ThenInclude(item => item.Book)
                              .Include(item => item.ImagesForCarousel)
                              .Include(item => item.OperatingModes)
                              .Where(item => item.Name == title)
                              .ToListAsync();
        }
    }
}
