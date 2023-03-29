using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IUrlProviderService _urlProviderService;

        public AuthorService(IAuthorRepository authorRepository, IUrlProviderService urlProviderService)
        {
            _authorRepository = authorRepository;
            _urlProviderService = urlProviderService;
        }

        public async Task<IEnumerable<Author>> GetAuthorsListAsync()
        {
            IEnumerable<Author> authors = await _authorRepository.GetFullInfoAuthorsAsync();
            foreach (var author in authors)
            {
                if (author.MiddleName is null)
                {
                    author.MiddleName = String.Empty;
                }
                author.Url = _urlProviderService.ConcatHostUrl(author.CoverImgPath);
            }
            return authors;
        }
        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            var author = await _authorRepository.GetFullInfoAuthorAsync(id);
            author.Url = _urlProviderService.ConcatHostUrl(author.CoverImgPath);

            foreach (var books in author.AuthorsBooks)
            {
                books.Book.Url = _urlProviderService.ConcatHostUrl(books.Book.CoverImgPath);
            }

            if (author.MiddleName is null)
            {
                author.MiddleName = String.Empty;
            }

            return author;
        }

        public async Task CreateAuthorAsync(Author author)
        {
            await _authorRepository.CreateAsync(author);
        }

        public async Task UpdateAuthorAsync(int id)
        {
            await _authorRepository.UpdateAsync(id);
        }

        public async Task DeleteAuthorAsync(int id)
        {
            await _authorRepository.DeleteAsync(id);
        }
    }
}
