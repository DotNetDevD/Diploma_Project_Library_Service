using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BookRepository : BaseRepository<Book> , IBookRepository
    {
        //нужно ли наследование?
        public BookRepository(LibraryDataBaseContext _db): base(_db)
        {
        }
        public async Task<List<Book>> GetAllFullInfoBooksAsync()
        {
            return await dbSet.Include(u => u.BooksGenres).Include(u => u.BooksLibraries).Include(u => u.AuthorsBooks).ToListAsync();
        }
    }
}
