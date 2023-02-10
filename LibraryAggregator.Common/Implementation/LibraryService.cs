using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly IUrlProviderService _urlProviderService;
        public LibraryService(ILibraryRepository libraryRepository, IUrlProviderService urlProviderService)
        {
            _libraryRepository = libraryRepository;
            _urlProviderService = urlProviderService;
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
            // TODO: extension method 
            Library library = await _libraryRepository.GetFullInfoLibraryAsync(id);
            library.Url = _urlProviderService.ConcatHostUrl(library.CoverImgPath);
            library.DirectorPhotoLink = _urlProviderService.ConcatHostUrl(library.DirectorPhotoLink);
            foreach (var imagesForCarousel in library.ImagesForCarousel)
            {
                imagesForCarousel.Url = _urlProviderService.ConcatHostUrl(imagesForCarousel.CoverImgPath);
            }
            return library;
        }

        public async Task<IEnumerable<Library>> GetLibrariesListAsync()
        {
            IEnumerable<Library> libraries = await _libraryRepository.GetFullInfoLibrariesAsync();
            foreach (var library in libraries)
            {
                library.Url = _urlProviderService.ConcatHostUrl(library.CoverImgPath);
                library.DirectorPhotoLink = _urlProviderService.ConcatHostUrl(library.DirectorPhotoLink);
                foreach (var imagesForCarousel in library.ImagesForCarousel)
                {
                    imagesForCarousel.Url = _urlProviderService.ConcatHostUrl(imagesForCarousel.CoverImgPath);
                }
            }
            return libraries;
        }

        public async Task UpdateLibraryAsync(int id)
        {
            await _libraryRepository.UpdateAsync(id);
        }
    }
}
