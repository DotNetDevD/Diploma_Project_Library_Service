using LibraryAggregator.Common.Helpers;
using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using System.Web.Http.Results;

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
      var noAdmin = new Admin() { Message = "NoAdmin" };
      return noAdmin;
    }
    admin.Token = new JwtToken().CreateToken(admin);
    return admin;
   
  }
}

