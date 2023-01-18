using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly LibraryDataBaseContext _db;

        public GenresController(LibraryDataBaseContext db)
        {
            _db = db;
            if (!db.Genres.Any())
            {
                List<Genre> genres = new List<Genre>()
                {
                    new Genre() {Type = "Fantasy"},
                    new Genre() {Type = "Science Fiction"},
                    new Genre() {Type = "Adventure"},
                    new Genre() {Type = "Romance"},
                    new Genre() {Type = "Detective"},
                    new Genre() {Type = "Horror"},
                    new Genre() {Type = "Biography"},
                    new Genre() {Type = "Education"},
                    new Genre() {Type = "Humor & Entertainment"},
                };
                db.Genres.AddRange(genres);
                db.SaveChanges();
            }
        }

        // GET: api/<GenresController>
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await _db.Genres.ToListAsync();
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            var genre = await _db.Genres.FindAsync(id);
            if (genre != null)
            {
                return genre;
            }
            return NotFound();
        }

        // POST api/<GenresController>
        [HttpPost]
        public async Task<ActionResult<Genre>> Post(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _db.Genres.Add(genre);
                await _db.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = genre.GenreId }, genre);
            }
            return BadRequest(ModelState);                
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var genre = await _db.Genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            _db.Genres.Remove(genre);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
