using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository() : base()
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
