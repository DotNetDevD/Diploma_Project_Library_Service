using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.ViewModel;

namespace LibraryAggregator.Common.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Book>> GetBooksListAsync()
        {
            return await _bookRepository.GetAllFullInfoBooksAsync();
        }
        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.GetByIdAsync(id);
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

        public async Task<IEnumerable<BookVM>> GetInfoForBookVM()
        {
            return await _bookRepository.GetInfoForBookVM();
        }
    }
}
