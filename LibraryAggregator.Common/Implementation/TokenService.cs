using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace LibraryAggregator.Common.Implementation
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly RSA _key;

        public TokenService(IConfiguration config)
        {
            _config = config;
            _key = new RSACryptoServiceProvider(2048);
        }
        public string CreateToken(AppUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.DisplayName)
            };

            var creds = new SigningCredentials(new RsaSecurityKey(_key), SecurityAlgorithms.RsaSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds,
                Issuer = _config["Token:Issuer"]
            };

            var takenHandler = new JwtSecurityTokenHandler();
            var token = takenHandler.CreateToken(tokenDescriptor);

            return takenHandler.WriteToken(token);
        }
    }
}
