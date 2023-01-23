using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System.Net;
using System.Web.Http;

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
            var authorList = await _repositoryWrapper.Author.GetAllFullInfoAuthorsAsync();
            if (authorList is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return authorList;
        }

        public async Task<Author> Get(int id)
        {
            var author = await _repositoryWrapper.Author.Get(id);
            if (author is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return author;
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
