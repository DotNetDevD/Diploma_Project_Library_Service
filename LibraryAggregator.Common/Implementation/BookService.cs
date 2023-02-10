using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAggregator.Common.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IConfiguration _configuration;
        public BookService(IBookRepository bookRepository, IConfiguration configuration)
        {
            _bookRepository = bookRepository;
            _configuration = configuration;
        }

        public async Task<IEnumerable<Book>> GetBooksListAsync()
        {
            List<Book> books = await _bookRepository.GetFullInfoBooksAsync();
            books.ForEach(b => ConcatStaticUrl(b));
            return books;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            Book book = await _bookRepository.GetFullInfoBookAsync(id);
            ConcatStaticUrl(book);
            return book;
        }

        private void ConcatStaticUrl(Book book)
        {
            var imageStorageHost = _configuration["ImageStorageHost"];
            book.Url = $"{imageStorageHost}{book.CoverImgPath}";
        }

        public async Task CreateBookAsync(Book book)
        {
            await _bookRepository.CreateAsync(book);
        }

        public async Task UpdateBookAsync(int id)
        {
            await _bookRepository.UpdateAsync(id);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _bookRepository.DeleteAsync(id);
        }       
    }
}

