using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

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
    }
}
