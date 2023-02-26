using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
    public interface IClientService
    {
        Task CreateClientAsync(ClientDto clientDto);
        Task DeleteClientAsync(int id);
        Task<IEnumerable<Client>> GetClientListAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task UpdateClientAsync(int id);
    }
}
