using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.Common.Logics
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
            return await _repositoryWrapper.Book.GetAllFullInfoBooksAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _repositoryWrapper.Book.Get(id);
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
