using LibraryAggregator.DataLayer;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryAggregator.Common.Implementation;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookLogic _logic;
        
        public BooksController(IRepositoryWrapper repositoryWrapper)
        {
            _logic = new BookLogic(repositoryWrapper);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get() => Ok(await _logic.Get());

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id) => await _logic.Get(id);

        [HttpPost]
        public void Post(Book book) => _logic.Post(book);

        [HttpPut("{id}")]
        public void Put(int id) => _logic.Put(id);

        [HttpDelete("{id}")]
        public void Delete(int id) => _logic.Delete(id);
    }
}
