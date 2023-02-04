using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository
    {

        public LibraryRepository(LibraryDataBaseContext db) : base( db)
        {
            
        }
        public async Task<List<Library>> GetAllFullInfoLibrariesAsync()
        {

            return await dbSet.Include(item => item.BooksLibraries)
                              .ThenInclude(item => item.Book)
                              .Include(item => item.ImagesForCarousel)
                              .Include(item => item.OperatingModes).ToListAsync();
                             
        }
    }
}
