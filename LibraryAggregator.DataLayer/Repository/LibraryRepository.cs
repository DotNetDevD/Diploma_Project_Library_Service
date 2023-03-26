using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
  public class LibraryRepository : BaseRepository<Library>, ILibraryRepository
  {
    public LibraryRepository(LibraryDataBaseContext db) : base(db)
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

    public async Task<IEnumerable<Library>> SearchTermByUserInput(string title)
    {
      return await dbSet.Include(item => item.BooksLibraries)
                           .ThenInclude(item => item.Book)
                        .Include(item => item.ImagesForCarousel)
                        .Include(item => item.OperatingModes)
                        .Where(item => item.Name.Contains(title))
                        .ToListAsync();
    }

    public async Task<Library> GetCurrentBooksInLibrary(string adminNAme)
    {
      return await dbSet.Include(item => item.BooksLibraries)
                             .ThenInclude(item => item.Book)
                             .FirstOrDefaultAsync(item => item.Admin.Login == adminNAme);
    }
  }
}
