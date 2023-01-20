using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using LibraryAggregator.DataLayer.Repository;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorRepository _dbAuthor = new();

        [HttpGet(Name = "Home")]
        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            return await _dbAuthor.GetAllFullInfoAuthorsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> Get(int id)
        {
            return await _dbAuthor.Get(id);
        }

        [HttpPost]
        public void Post(Author author)
        {
            _dbAuthor.Create(author);
        }

        [HttpPut]
        public void Put(int id)
        {
            _dbAuthor.Update(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dbAuthor.Delete(id);
        }
    }
}
