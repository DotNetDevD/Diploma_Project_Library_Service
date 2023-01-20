using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private GenreRepository _dbGenre = new();

        // GET: api/<GenresController>
        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await _dbGenre.GetAllFullInfoGenresAsync();
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            return await _dbGenre.Get(id);
        }

        // POST api/<GenresController>
        [HttpPost]
        public void Post(Genre genre)
        {
            _dbGenre.Create(genre);
        }

        // PUT api/<GenresController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            _dbGenre.Update(id);
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dbGenre.Delete(id);
        }

    }
}
