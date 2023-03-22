using LibraryAggregator.Common.Helpers;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using LibraryAggregator.DataLayer.Repository.IRepository;
namespace LibraryAggregator.Common.Implementation;

public class AdminService : IAdminService
{
  private readonly IAdminRepository _adminRepository;

  public AdminService(IAdminRepository adminRepository)
  {
    _adminRepository = adminRepository;
  }

  public async Task<Admin> AdminAuth(RequestLogin request)
  {
    request.Password = PasswordHasher.HashPassword(request.Password);
    var admin = await _adminRepository.GetAdmin(request);
    if(admin is null)
    {
      var noAdmin = new Admin() { Message = nameof(AdminEnum.NoAdmin)};
      return noAdmin;
    }
    admin.Token = new JwtToken().CreateToken(admin);
    return admin;
  }

  public async Task<Admin> GetAdminByLogin(int id)
  {
     return await _adminRepository.GetAdminByLogin(id);
  }

  public async Task<string> NewRefreshToken()
  {
    var jwt = new JwtToken().CreateRefreshToken();
    var cheakToken  = await _adminRepository.RefreshToken(jwt);
    if (cheakToken)
    {
       await NewRefreshToken();
    }
    return jwt;
  }
}

