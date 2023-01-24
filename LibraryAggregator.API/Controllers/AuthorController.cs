using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.Common.Interface;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet(Name = "Home")]
        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            var authors = await _authorService.Get();

            return !authors?.Any() ?? true ? NotFound() : Ok(await _authorService.Get());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> Get(int id) => await _authorService.GetAsync(id);

        [HttpPost]
        public void Post(Author author) => _authorService.Add(author);

        [HttpPut]
        public void Put(int id) => _authorService.Update(id);

        [HttpDelete("{id}")]
        public void Delete(int id) => _authorService.Delete(id);
    }
}