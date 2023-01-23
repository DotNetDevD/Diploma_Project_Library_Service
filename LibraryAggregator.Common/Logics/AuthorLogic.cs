using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;


namespace LibraryAggregator.Common.Logics
{

    
    public class AuthorLogic
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public AuthorLogic(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<IEnumerable<Author>> Get()
        {
            return await _repositoryWrapper.Author.GetAllFullInfoAuthorsAsync();
        }

        public async Task<Author> Get(int id)
        {
            return await _repositoryWrapper.Author.Get(id);
        }

        public void Post(Author author)
        {
            _repositoryWrapper.Author.Create(author);
        }

        public void Put(int id)
        {
            _repositoryWrapper.Author.Update(id);
        }

        public void Delete(int id)
        {
            _repositoryWrapper.Author.Delete(id);
        }

    }
}
