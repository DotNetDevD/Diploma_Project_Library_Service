using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface ILibraryRepository : IRepository<Library> , IGenericSearchRepository<Library>
    {
        Task<IEnumerable<Library>> GetFullInfoLibrariesAsync();
        Task<Library> GetFullInfoLibraryAsync(int id);
         Task<Library> GetCurrentBooksInLibrary(string adminNAme);
    }
}
