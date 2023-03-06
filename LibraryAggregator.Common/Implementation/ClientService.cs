using Azure.Core;
using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System.Security.Cryptography;
using System.Text;

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

    public async Task<int> GetClientByEmailAsync(string email)
    {
      return await _clientRepository.GetClientIdByEmailAsync(email);
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

    public async Task<Client> RegisterClient(AdminEntryRequest adminEntryRequest)
    {
        
      if (adminEntryRequest is null)
      {
        using var algo = new HMACSHA512();
        var salt = algo.Key;
        var password = algo.ComputeHash(Encoding.UTF8.GetBytes(clientRegisterRequest.Password));

        var clientCridantional = new ClientCredential();
        clientCridantional.Email = clientRegisterRequest.Email;
        clientCridantional.PasswordHash = password;
        clientCridantional.PasswordSalt = salt;
        _clientRepository.CreateAsync(client);
        return client;
      }
      return client;

    }

    public Task<Client> GetClientByEmail(string email)
    {
      throw new NotImplementedException();
    }
  }
}
