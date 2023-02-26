using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> GetFullInfoClientAsync(int id);
        Task<IEnumerable<Client>> GetFullInfoClientsAsync();
        Task<int> GetClientIdByEmailAsync(string email);
    }
}
