using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IAuthorService
    {
        void Add(Author author);
        void Delete(int id);
        Task<IEnumerable<Author>> Get();
        Task<Author> GetAsync(int id);
        void Update(int id);
    }
}