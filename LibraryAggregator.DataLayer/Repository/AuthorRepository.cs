using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDataBaseContext _db) : base(_db)
        {
            if (!dbSet.Any())
            {
                dbSet.Add(new Author { FirstName = "Mark", LastName = "Twain" });
                dbSet.Add(new Author { FirstName = "Ernest", LastName = "Hemingway" });
                Save();
            }
        }
        public async Task<List<Author>> GetAllFullInfoAuthorsAsync()
        {
            return await dbSet.Include(u => u.AuthorsBooks).ToListAsync();
        }
    }
}
