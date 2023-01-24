using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;


namespace LibraryAggregator.DataLayer.Repository
{
    public class GenreRepository : BaseRepository<Genre> , IGenreRepository
    {
        public GenreRepository(LibraryDataBaseContext _db) : base(_db)
        {
            //if (!dbSet.Any())
            //{
            //    List<Genre> genres = new List<Genre>()
            //    {
            //        new Genre() {Type = "Fantasy"},
            //        new Genre() {Type = "Science Fiction"},
            //        new Genre() {Type = "Adventure"},
            //        new Genre() {Type = "Romance"},
            //        new Genre() {Type = "Detective"},
            //        new Genre() {Type = "Horror"},
            //        new Genre() {Type = "Biography"},
            //        new Genre() {Type = "Education"},
            //        new Genre() {Type = "Humor & Entertainment"},
            //    };
            //    dbSet.AddRange(genres);
            //    Save();
            //}
        }
        public async Task<List<Genre>> GetAllFullInfoGenresAsync()
        {
            return await dbSet.Include(u => u.BooksGenres).ToListAsync();
        }
    }
}
