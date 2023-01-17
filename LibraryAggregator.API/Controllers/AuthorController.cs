using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly LibraryDataBaseContext _db;
        public AuthorController(LibraryDataBaseContext db)
        {
            _db = db;
            if (!db.Authors.Any())
            {
                db.Authors.Add(new Author { AuthorId = 1, FirstName = "Mark", LastName = "Twain" });
                db.Authors.Add(new Author { AuthorId = 2, FirstName = "Ernest", LastName = "Hemingway" });
                db.SaveChanges();
            }
        }
        [HttpGet(Name = "Home")]
        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            return await _db.Authors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Author> Get(int id)
        {
            var Author = _db.Authors.FirstOrDefault(x => x.AuthorId == id);
            return Author;
        }

        [HttpPost]
        public IActionResult Post(Author author)
        {
            if (ModelState.IsValid)
            {
                _db.Authors.Add(author);
                _db.SaveChanges();
                return Ok(author);

            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Author author)
        {
            if (ModelState.IsValid)
            {
                _db.Update(author);
                _db.SaveChanges();
                return Ok(author);
            }
            return BadRequest(author);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var author = _db.Authors.FirstOrDefault(item => item.AuthorId == id);
            if (author != null)
            {
                _db.Authors.Remove(author);
                _db.SaveChanges();
            }
            return Ok(author);
        }
    }
}
