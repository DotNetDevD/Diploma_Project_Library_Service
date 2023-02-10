using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.Extensions.Configuration;

namespace LibraryAggregator.Common.Implementation
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IConfiguration _configuration;

        public AuthorService(IAuthorRepository authorRepository, IConfiguration configuration)
        {
            _authorRepository = authorRepository;
            _configuration = configuration;
        }

        public async Task<IEnumerable<Author>> GetAuthorsListAsync()
        {
            List<Author> authors = await _authorRepository.GetFullInfoAuthorsAsync();
            authors.ForEach(a => ConcatStaticUrl(a));
            return authors;
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            var author = await _authorRepository.GetFullInfoAuthorAsync(id);
            ConcatStaticUrl(author);
            return author;
        }

        private void ConcatStaticUrl(Author author)
        {
            var imageStorageHost = _configuration["ImageStorageHost"];
            author.Url = $"{imageStorageHost}{author.CoverImgPath}";
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
