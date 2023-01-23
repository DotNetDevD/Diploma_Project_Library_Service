using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.Common.Logics;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorLogic _logic;

        public AuthorController( IRepositoryWrapper repositoryWrapper)
        {
            _logic = new AuthorLogic(repositoryWrapper);
        }


        [HttpGet(Name = "Home")]
        public async Task<ActionResult<IEnumerable<Author>>> Get() => Ok(await _logic.Get());

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> Get(int id) => await _logic.Get(id);

        [HttpPost]
        public void Post(Author author) => _logic.Post(author);

        [HttpPut]
        public void Put(int id) => _logic.Put(id);

        [HttpDelete("{id}")]
        public void Delete(int id) => _logic.Delete(id);
    }
}
