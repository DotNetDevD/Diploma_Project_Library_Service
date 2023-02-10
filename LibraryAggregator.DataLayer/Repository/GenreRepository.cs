using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;


namespace LibraryAggregator.DataLayer.Repository
{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(LibraryDataBaseContext _db) : base(_db)
        {
        }
        public async Task<IEnumerable<Genre>> GetFullInfoGenresAsync()
        {
            return await dbSet.Include(u => u.BooksGenres).ToListAsync();
        }
    }
}
