using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAggregator.Common.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public async Task<IEnumerable<Genre>> GetGenresListAsync()
        {
            return await _genreRepository.GetFullInfoGenresAsync();
        }
        public async Task<Genre> GetByIdAsync(int id)
        {
            return await _genreRepository.GetByIdAsync(id);
        }
        public async Task CreateGenreAsync(Genre genre)
        {
            await _genreRepository.CreateAsync(genre);
        }
        public async Task UpdateGenreAsync(int id)
        {
            await _genreRepository.UpdateAsync(id);
        }
        public async Task DeleteGenreAsync(int id)
        {
            await _genreRepository.DeleteAsync(id);
        }
    }
}
