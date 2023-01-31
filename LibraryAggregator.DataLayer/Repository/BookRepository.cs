using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDataBaseContext _db) : base(_db)
        {
        }
        public async Task<List<Book>> GetAllFullInfoBooksAsync()
        {
            return await dbSet.Include(u => u.BooksGenres)
                .ThenInclude(bl => bl.Genre)
                .Include(u => u.AuthorsBooks)
                .ThenInclude(u => u.Author)
                .ToListAsync();
        }

        public async Task<List<BookVM>> GetInfoForBookVM()
        {
            List<Book> listBook = await GetAllFullInfoBooksAsync();
            List<BookVM> listBookVM = new();

            foreach (var item in listBook)
            {
                BookVM bookForVM = new BookVM();
                bookForVM.Isbn = item.Isbn;
                bookForVM.Title = item.Title;
                bookForVM.PublishDate = item.PublishDate;
                foreach (var autor in item.AuthorsBooks)
                {
                    bookForVM.AuthorFullName += $"{autor.Author.FirstName} {autor.Author.LastName}; ";
                }
                foreach (var genre in item.BooksGenres)
                {
                    bookForVM.GenreType += $"{genre.Genre.Type}; ";
                }
                bookForVM.PageCount = item.PageCount;

                listBookVM.Add(bookForVM);
            }
            return listBookVM;
        }
    }
}