using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task CreateClientAsync(ClientDto clientDto)
        {
            //TODO: check unique data
            Client client = new()
            {
                Name = clientDto.Name,
                Surname = clientDto.Surname,
                Email = clientDto.Email,
                PhoneNumber = clientDto.PhoneNumber,
            };
            await _clientRepository.CreateAsync(client);
        }

        public async Task DeleteClientAsync(int id)
        {
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _clientRepository.GetFullInfoClientAsync(id);
        }

        public async Task<IEnumerable<Client>> GetClientListAsync()
        {
            return await _clientRepository.GetFullInfoClientsAsync();
        }

        //TODO: correct put method
        public async Task UpdateClientAsync(int id)
        {
            await _clientRepository.UpdateAsync(id);
        }
    }
}
