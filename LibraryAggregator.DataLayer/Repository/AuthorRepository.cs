using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository 
    {
        public AuthorRepository(LibraryDataBaseContext _db) : base(_db)
        {
        }

        public async Task<Author> GetFullInfoAuthorAsync(int id)
        {
            return await dbSet.Include(u => u.AuthorsBooks)
                .ThenInclude(b => b.Book)
                .FirstOrDefaultAsync(a => a.AuthorId == id);
        }

        public async Task<IEnumerable<Author>> GetFullInfoAuthorsAsync()
        {
            return await dbSet.Include(u => u.AuthorsBooks)
                .ToListAsync();
        }

        public async Task<IEnumerable<Author>> SearchSomeEntityByTitle(string title)
        {
            return await dbSet.Include(item => item.AuthorsBooks)
                                 .ThenInclude(item => item.Book)
                              .Where(item => item.FirstName + item.MiddleName + item.LastName == title)
                              .ToListAsync();
        }
    }
}