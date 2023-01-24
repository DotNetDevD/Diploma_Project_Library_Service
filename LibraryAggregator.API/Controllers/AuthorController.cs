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

        [HttpGet(Name = "AuthorsList")]
        public async Task<ActionResult<IEnumerable<Author>>> GetListAsync()
        {
            var authors = await _authorService.GetAuthorsListAsync();

            return !authors?.Any() ?? true ? NotFound() : Ok(await _authorService.GetAuthorsListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetByIdAsync(int id)
        {
            return await _authorService.GetAuthorByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Author author)
        {
            await _authorService.CreateAuthorAsync(author);
        }

        [HttpPut]
        public async Task UpdateAsync(int id)
        {
            await _authorService.UpdateAuthorAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
        }
    }
}