using Microsoft.AspNetCore.Mvc;
using LibraryAggregator.Common.Dtos;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace LibraryAggregator.API.Controllers
{
  public class ClientController : ApiBaseController
  {
    private readonly IClientService _clientService;
    private readonly AuthOptions _authOptions;

    public ClientController(IClientService clientService, AuthOptions authOptions)
    {
      _clientService = clientService;
      _authOptions = authOptions;
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
    [HttpPost("login")]
    public async Task<LoginResponse> loginUser(LoginRequest loginRequest)
    {
      var user =  await _clientService.GetClientByEmail(loginRequest.Email);

      var response = new LoginResponse();

      if (user == null)
      {
        response.IsSuccess = false;
        return response;
      }

      using var algo = new HMACSHA512(user.PasswordSalt);
      var providedPassword = algo.ComputeHash(Encoding.UTF8.GetBytes(loginRequest.Password));

      var isValidPassword = providedPassword.SequenceEqual(user.PasswordHash);

      if (!isValidPassword)
      {
        response.IsSuccess = false;
        return response;
      }

      var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, loginRequest.Email),
        // add sort of refresh token
                };


      var tokenExpiresAt = DateTime.UtcNow.Add(TimeSpan.FromDays(2));
      var jwt = new JwtSecurityToken(
      issuer: _authOptions.Issuer,
              audience: _authOptions.Audience,
              claims: claims,
              expires: tokenExpiresAt,
              signingCredentials: new SigningCredentials(_authOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

      response.ExpiresAt = tokenExpiresAt;
      response.IsSuccess = true;
      response.Token = new JwtSecurityTokenHandler().WriteToken(jwt);


      return response;
    }


  }
}
