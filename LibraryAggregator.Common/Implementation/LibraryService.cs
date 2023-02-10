using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAggregator.Common.Implementation
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IConfiguration _configuration;
        public LibraryService(ILibraryRepository libraryRepository, IConfiguration configuration)
        {
            _libraryRepository = libraryRepository;
            _configuration = configuration;
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

        public async Task<Library> GetLibraryInfoAsync(int id)
        {
            Library library = await _libraryRepository.GetFullInfoLibraryAsync(id);
            ConcatStaticUrl(library);
            return library;
        }

        public async Task<IEnumerable<Library>> GetLibrariesListAsync()
        {
            List<Library> libraries = await _libraryRepository.GetFullInfoLibrariesAsync();
            libraries.ForEach(l => ConcatStaticUrl(l));
            return libraries;
        }

        private void ConcatStaticUrl(Library library)
        {
            var imageStorageHost = _configuration["ImageStorageHost"];

            // library.ImagesForCarousel.ForEach не работает из-за интерфест ICollection не имеет доступного расширеня
            foreach (var imagesForCarousel in library.ImagesForCarousel)
            {
                imagesForCarousel.Url = $"{imageStorageHost}{imagesForCarousel.CoverImgPath}";
            }
            library.DirectorPhotoLink = $"{imageStorageHost}{library.DirectorPhotoLink}";
            library.Url = $"{imageStorageHost}{library.CoverImgPath}";
        }

        public async Task UpdateLibraryAsync(int id)
        {
            await _libraryRepository.UpdateAsync(id);
        }
    }
}
