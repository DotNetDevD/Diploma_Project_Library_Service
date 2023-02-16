using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IAuthorRepository : IRepository<Author> , IGenericSearchRepository<Author>
    {
        Task<IEnumerable<Author>> GetFullInfoAuthorsAsync();
        Task<Author> GetFullInfoAuthorAsync(int id);
    }
}
