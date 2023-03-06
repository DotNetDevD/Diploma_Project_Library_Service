using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
  public class AdminService : IAdminService
  {
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminRepository adminRepository)
    {
      _adminRepository = adminRepository;
    }

    public Task<LibraryAdmin> GetLibraryAdminByEmailAsync(string email)
    {
        return _adminRepository.GetLibraryAdminByEmail(email);
    }
  }
}
