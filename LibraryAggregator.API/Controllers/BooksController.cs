using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.Common.Interface;


namespace LibraryAggregator.API.Controllers
{
    public class BooksController : ApiBaseController
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(Name = "BooksList")]
        public async Task<IEnumerable<Book>> GetListAsync()
        {
            return await _bookService.GetBooksListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetByIdAsync(int id)
        {
            return await _bookService.GetBookByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Book book)
        {
            await _bookService.CreateBookAsync(book);
        }

        [HttpPut("{id}")]
        public async Task UpdateAsync(int id)
        {
            await _bookService.UpdateBookAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _bookService.DeleteBookAsync(id);
        }
    }
}
