using LibraryAggregator.DataLayer.Entities;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace LibraryAggregator.Common.Helpers
{
  public class JwtToken
  {
    public string CreateToken(Admin admin)
    {
      var jwtTokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes("SuperSecretCode.............");
      var identity = new ClaimsIdentity(new Claim[]
      {
         new Claim(ClaimTypes.Name , admin.Login)
      });

      var credentionals = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = identity,
        Expires = DateTime.Now.AddMinutes(15),
        SigningCredentials = credentionals
      };

      var token = jwtTokenHandler.CreateToken(tokenDescriptor);
      return jwtTokenHandler.WriteToken(token);
    }
  }
}
