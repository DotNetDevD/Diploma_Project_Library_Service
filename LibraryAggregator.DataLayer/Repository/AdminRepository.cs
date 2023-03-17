using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace LibraryAggregator.DataLayer.Repository;
public class AdminRepository : IAdminRepository
{
  private readonly LibraryDataBaseContext _libraryDataBaseContext;
  public AdminRepository(LibraryDataBaseContext libraryDataBaseContext)
  {
    _libraryDataBaseContext = libraryDataBaseContext;
  }

  public async Task<Admin> GetAdmin(string password , string login)
  {
    return await _libraryDataBaseContext.Admin.FirstOrDefaultAsync(item => item.Password == password && item.Login==login);
  }
}

