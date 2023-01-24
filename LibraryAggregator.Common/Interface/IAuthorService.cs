using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IAuthorService
    {
        Task CreateAuthorAsync(Author author);
        Task DeleteAuthorAsync(int id);
        Task<IEnumerable<Author>> GetAuthorsListAsync();
        Task<Author> GetAuthorByIdAsync(int id);
        Task UpdateAuthorAsync(int id);
    }
}