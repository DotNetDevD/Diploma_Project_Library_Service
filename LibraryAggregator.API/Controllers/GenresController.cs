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
        public async Task<IEnumerable<Genre>> GetListAsync()
        {
            return await _genreService.GetGenresListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Genre> GetByIdAsync(int id)
        {
            return await _genreService.GetByIdAsync(id);
        }

        //TODO: POST UI and Attribute authorize
        [HttpPost]
        public async Task CreateAsync(Genre genre)
        {
            await _genreService.CreateGenreAsync(genre);
        }

        //TODO: PUT and Attribute authorize
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id)
        {
            await _genreService.UpdateGenreAsync(id);
        }

        //TODO: DELETE UI and Attribute authorize
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _genreService.DeleteGenreAsync(id);
        }
    }
}
