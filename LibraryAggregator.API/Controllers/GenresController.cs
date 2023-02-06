using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class GenresController : ApiBaseController
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet(Name = "GenresList")]
        public async Task<ActionResult<IEnumerable<Genre>>> GetListAsync()
        {
            var genres = await _genreService.GetGenresListAsync();
            return !genres?.Any() ?? true ? NotFound() : Ok(await _genreService.GetGenresListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Genre>> GetByIdAsync(int id)
        {
            return await _genreService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Genre genre)
        {
            await _genreService.CreateGenreAsync(genre);
        }

        [HttpPut("{id}")]
        public async Task UpdateAsync(int id)
        {
            await _genreService.UpdateGenreAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _genreService.DeleteGenreAsync(id);
        }
    }
}
