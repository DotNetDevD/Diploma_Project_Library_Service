using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository;
public class AdminRepository : IAdminRepository
{
  private readonly LibraryDataBaseContext _libraryDataBaseContext;
  public AdminRepository(LibraryDataBaseContext libraryDataBaseContext)
  {
    _libraryDataBaseContext = libraryDataBaseContext;
  }

  public async Task<Admin> GetAdmin(RequestLogin request)
  {
    return await _libraryDataBaseContext.Admin.FirstOrDefaultAsync(item => item.Password == request.Password && item.Login== request.adminName);
  }

  public async Task<Admin> GetAdminByLogin(int id)
  {
    return await _libraryDataBaseContext.Admin.Where(item => item.AdminId == id)
                                              .FirstOrDefaultAsync();
  }

  public async Task<bool> RefreshToken(string refreshToken)
  {
    return await _libraryDataBaseContext.Admin.AnyAsync(item => item.RefreshToken == refreshToken);
  }
}

