using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System.Net;
using System.Web.Http;

namespace LibraryAggregator.Common.Implementation
{
    public class BookLogic
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public BookLogic(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;

        }

        public async Task<IEnumerable<Book>> Get()
        {
            var bookList = await _repositoryWrapper.Book.GetAllFullInfoBooksAsync();
            if (bookList is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return bookList;
        }

        public async Task<Book> Get(int id)
        {
            var book = await _repositoryWrapper.Book.Get(id);
            if (book is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return book;
        }

        public void Post(Book book)
        {
            _repositoryWrapper.Book.Create(book);
        }

        public void Put(int id)
        {
            _repositoryWrapper.Book.Update(id);
        }

        public void Delete(int id)
        {
            _repositoryWrapper.Book.Delete(id);
        }
    }
}
