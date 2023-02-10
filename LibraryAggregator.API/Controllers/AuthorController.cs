using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.Common.Interface;

namespace LibraryAggregator.API.Controllers
{
    public class AuthorController : ApiBaseController
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet(Name = "AuthorsList")]
        public async Task<IEnumerable<Author>> GetListAsync()
        {
            return await _authorService.GetAuthorsListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Author> GetByIdAsync(int id)
        {
            return await _authorService.GetAuthorByIdAsync(id);
        }

        //TODO: POST UI and Attribute authorize
        [HttpPost]
        public async Task CreateAsync(Author author)
        {
            await _authorService.CreateAuthorAsync(author);
        }

        //TODO: PUT and Attribute authorize
        [HttpPut]
        public async Task UpdateAsync(int id)
        {
            await _authorService.UpdateAuthorAsync(id);
        }

        //TODO: DELETE UI and Attribute authorize
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
        }
    }
}