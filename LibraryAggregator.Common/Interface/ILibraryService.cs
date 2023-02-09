using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface ILibraryService
    {
        Task CreateLibraryAsync(Library library);
        Task DeleteLibraryAsync(int id);
        Task<Library> GetByIdAsync(int id);
        Task<IEnumerable<Library>> GetLibrariesListAsync();
        Task UpdateLibraryAsync(int id);
        Task<Library> GetLibrariesListAsync(int id);
    }
}
