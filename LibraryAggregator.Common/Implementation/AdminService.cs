using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation;

public class AdminService : IAdminService
{
  private readonly IAdminRepository _adminRepository;

  public AdminService(IAdminRepository adminRepository)
  {
    _adminRepository = adminRepository;
  }

  public async Task<Admin> AdminAuth(string password, string login)
  {
    return await _adminRepository.GetAdmin(password, login);
  }
}

