using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly LibraryDataBaseContext _db;

        public BooksController(LibraryDataBaseContext db)
        {
            _db = db;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult<List<Book>>> Get()
        {
            return await _db.Books.ToListAsync();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book != null)
            {
                return book;
            }
            return NotFound();
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<ActionResult<Genre>> Post(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                await _db.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = book.BookId }, book);
            }
            return BadRequest(ModelState);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
