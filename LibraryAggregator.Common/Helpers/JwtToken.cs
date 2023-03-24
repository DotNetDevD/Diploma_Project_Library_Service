using LibraryAggregator.DataLayer.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using LibraryAggregator.Common.Dtos;
using LibraryAggregator.DataLayer;

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
        Expires = DateTime.Now.AddSeconds(10),
        SigningCredentials = credentionals
      };

      var token = jwtTokenHandler.CreateToken(tokenDescriptor);
      return jwtTokenHandler.WriteToken(token);
    }
    public string CreateRefreshToken() // Случайная строка 
    {
      var tokenBytes = RandomNumberGenerator.GetBytes(64);
      var refreshToken = Convert.ToBase64String(tokenBytes);
      return refreshToken;
    }

    public ClaimsPrincipal GetPrincipaleFromExpiredToken(string token)
    {
      var key = Encoding.ASCII.GetBytes("SuperSecretCode.............");
      var tokenValidationParametrs = new TokenValidationParameters
      {
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = false
      };
      var tokenHandler = new JwtSecurityTokenHandler();
      SecurityToken securityToken;
      var principal = tokenHandler.ValidateToken(token, tokenValidationParametrs, out securityToken);
      var jwtSecurityToken = securityToken as JwtSecurityToken;
      if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
        throw new SecurityTokenException("Invalid Token");
      return principal;
    }

    public async Task<TokenDto> GetTokens(Admin admin)
    {
      var newAccessToken = admin.Token;
      var newRefreshToken = new JwtToken().CreateRefreshToken();
      admin.RefreshToken = newRefreshToken;
      return new TokenDto { AccessToken = newAccessToken,
                            RefreshToken = newRefreshToken};
    }
  }

 
}
