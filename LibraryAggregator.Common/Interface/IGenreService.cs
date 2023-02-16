using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IGenreService
    {
        Task CreateGenreAsync(Genre genre);
        Task DeleteGenreAsync(int id);
        Task<Genre> GetByIdAsync(int id);
        Task<IEnumerable<Genre>> GetGenresListAsync();
        Task UpdateGenreAsync(int id);
       
    }
}