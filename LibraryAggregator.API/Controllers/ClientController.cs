using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.API.Controllers
{
    public class ClientController : ApiBaseController
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<Client> GetByIdAsync(int id)
        {
            return await _clientService.GetClientByIdAsync(id);
        }

        [HttpGet(Name = "ClientList")]
        public async Task<IEnumerable<Client>> GetListAsync()
        {
            return await _clientService.GetClientListAsync();
        }

        [HttpPost]
        public async Task CreateAsync(ClientDto clientDto)
        {
            await _clientService.CreateClientAsync(clientDto);
        }

        //TODO: correct put method
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id)
        {
            await _clientService.UpdateClientAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _clientService.DeleteClientAsync(id);
        }
    }
}
