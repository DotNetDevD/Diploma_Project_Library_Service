using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System.Net;
using System.Web.Http;

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
            var genreList = await _repositoryWrapper.Genre.GetAllFullInfoGenresAsync();
            if (genreList is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return genreList;
        }

        public async Task<Genre> Get(int id)
        {
            var genre = await _repositoryWrapper.Genre.Get(id);
            if (genre is null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            return genre;
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
