using LibraryAggregator.Common.Implementation;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly GenreLogic _logic;

        public GenresController(IRepositoryWrapper repositoryWrapper)
        {
            _logic = new GenreLogic(repositoryWrapper);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> Get() => Ok(await _logic.Get());

        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> Get(int id) => await _logic.Get(id);

        [HttpPost]
        public void Post(Genre genre) => _logic.Post(genre);

        [HttpPut("{id}")]
        public void Put(int id) => _logic.Put(id);

        [HttpDelete("{id}")]
        public void Delete(int id) => _logic.Delete(id);

    }
}
