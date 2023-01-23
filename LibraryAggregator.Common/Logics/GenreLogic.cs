using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.Common.Logics
{
    public class GenreLogic
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public GenreLogic(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<IEnumerable<Genre>> Get()
        {
            return await _repositoryWrapper.Genre.GetAllFullInfoGenresAsync();
        }

        public async Task<Genre> Get(int id)
        {
            return await _repositoryWrapper.Genre.Get(id);
        }

        public void Post(Genre genre)
        {
            _repositoryWrapper.Genre.Create(genre);
        }

        public void Put(int id)
        {
            _repositoryWrapper.Genre.Update(id);
        }

        public void Delete(int id)
        {
            _repositoryWrapper.Genre.Delete(id);
        }
    }
}
