using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet(Name = "LibrariesList")]
        public async Task<ActionResult<IEnumerable<Library>>> GetListAsync()
        {
            var library = await _libraryService.GetLibrariesListAsync();
            return !library?.Any() ?? true ? NotFound() : Ok(await _libraryService.GetLibrariesListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetByIdAsync(int id)
        {
            return await _libraryService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Library library)
        {
            await _libraryService.CreateLibraryAsync(library);
        }

        [HttpPut("{id}")]
        public async Task UpdateAsync(int id)
        {
            await _libraryService.UpdateLibraryAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _libraryService.DeleteLibraryAsync(id);
        }
    }
}
