using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.Common.Interface;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet("BooksListByGenreId/{genreId}")]
        public async Task<IEnumerable<Book>> GetListAsync(int genreId)
        {
            return await _bookService.GetBooksListByGenreAsync(genreId);
        }

        [HttpGet("BooksListByAuthorId/{authorId}")]
        public async Task<IEnumerable<Book>> GetBookListByAuthorIdAsync(int authorId)
        {
            return await _bookService.GetBookListByAuthorIdAsync(authorId);
        }

        [HttpGet("{id}")]
        public async Task<Book> GetByIdAsync(int id)
        {
            return await _bookService.GetBookByIdAsync(id);
        }

        //TODO: POST UI and Attribute authorize
        [HttpPost]
        public async Task CreateAsync(Book book)
        {
            await _bookService.CreateBookAsync(book);
        }

        //TODO: PUT and Attribute authorize
        [HttpPut("{id}")]
        [Authorize]
        public async Task UpdateAsync(int id)
        {
            await _bookService.UpdateBookAsync(id);
        }

        //TODO: DELETE UI and Attribute authorize
        [HttpDelete("{id}")]
        [Authorize]
        public async Task DeleteAsync(int id)
        {
            await _bookService.DeleteBookAsync(id);
        }
    }
}
