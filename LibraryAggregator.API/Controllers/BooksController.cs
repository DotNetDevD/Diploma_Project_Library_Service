using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.ViewModel;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(Name = "BooksList")]
        //public async Task<ActionResult<IEnumerable<Book>>> GetListAsync()
        //{
        //    var books = await _bookService.GetBooksListAsync();
        //    return !books?.Any() ?? true ? NotFound() : Ok(await _bookService.GetBooksListAsync());
        //}
        public async Task<IEnumerable<BookVM>> GetListAsync()
        {
            return await _bookService.GetInfoForBookVM();
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
