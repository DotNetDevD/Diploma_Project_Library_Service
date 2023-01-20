using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //правильно или через конструктор???
        private BookRepository _dbBook = new();
        //public BooksController()
        //{
        //    _dbBook = new BookRepository();
        //}

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            return await _dbBook.GetAllFullInfoBooksAsync();
                //_db.Books.Include(u => u.BooksGenres).Include(u => u.BooksLibraries).Include(u => u.AuthorsBooks).ToListAsync();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            return await _dbBook.Get(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post(Book book)
        {
            _dbBook.Create(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            _dbBook.Update(id);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dbBook.Delete(id);
        }
    }
}
