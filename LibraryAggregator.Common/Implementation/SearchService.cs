using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class SearchService : ISearchService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IGenreRepository _genreRepository;
        private readonly ILibraryRepository _libraryRepository;
        private readonly IUrlProviderService _urlProviderService;

        public SearchService(IAuthorRepository authorRepository, IBookRepository bookRepository,
            IGenreRepository genreRepository, ILibraryRepository libraryRepository,
            IUrlProviderService urlProviderService)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
            _genreRepository = genreRepository;
            _libraryRepository = libraryRepository;
            _urlProviderService = urlProviderService;
        }

        public async Task<IEnumerable<Author>> SearchAuthorsByFullName(string fullname)
        {
            var authors = await _authorRepository.SearchTermByUserInput(fullname);
            foreach (var author in authors)
            {
                if (author.MiddleName == null)
                {
                    author.MiddleName = String.Empty;
                }
                author.Url = _urlProviderService.ConcatHostUrl(author.CoverImgPath);
            }
            return authors;
        }

        public async Task<IEnumerable<Book>> SearchBooksByTitle(string title)
        {
            IEnumerable<Book> books = await _bookRepository.SearchTermByUserInput(title);
            foreach (var book in books)
            {
                book.Url = _urlProviderService.ConcatHostUrl(book.CoverImgPath);
            }
            return books;
        }

        public async Task<SearchBookLibraryAuthor> SearchBookLibraryAuthorByInput(string input)
        {
            SearchBookLibraryAuthor? searchResult = new()
            {
                Books = await SearchBooksByTitle(input),
                Authors = await SearchAuthorsByFullName(input),
                Libraries = await SearchLibrariesByName(input)
            };
            return searchResult;
        }

        public async Task<IEnumerable<Genre>> SearchGenreByType(string type)
        {
            return await _genreRepository.SearchTermByUserInput(type);
        }

        public async Task<IEnumerable<Library>> SearchLibrariesByName(string name)
        {
            IEnumerable<Library> libraries = await _libraryRepository.SearchTermByUserInput(name);
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
    }
}
