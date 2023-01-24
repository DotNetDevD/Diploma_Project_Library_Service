using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;


namespace LibraryAggregator.Common.Implementation
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository=authorRepository;
        }

        public async Task<IEnumerable<Author>> Get()
        {
            var authorList = await _authorRepository.GetAllFullInfoAuthorsAsync();
            return authorList;
        }

        public async Task<Author> GetAsync(int id)
        {
            var author = await _authorRepository.Get(id);
            return author;
        }

        public void Add(Author author)
        {
            _authorRepository.Create(author);
        }

        public void Update(int id)
        {
            _authorRepository.Update(id);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

    }
}
