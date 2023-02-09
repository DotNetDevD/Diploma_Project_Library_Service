using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        public LibraryService(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        public async Task CreateLibraryAsync(Library library)
        {
            await _libraryRepository.CreateAsync(library);
        }

        public async Task DeleteLibraryAsync(int id)
        {
            await _libraryRepository.DeleteAsync(id);
        }

        public async Task<Library> GetByIdAsync(int id)
        {
            return await _libraryRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Library>> GetLibrariesListAsync()
        {
            return await _libraryRepository.GetFullInfoLibrariesAsync();
        }

        public async Task UpdateLibraryAsync(int id)
        {
            await _libraryRepository.UpdateAsync(id);
        }
        public async Task<Library> GetLibrariesListAsync(int id)
        {
            return await _libraryRepository.GetFullInfoLibraryAsync(id);
        }
    }
}
