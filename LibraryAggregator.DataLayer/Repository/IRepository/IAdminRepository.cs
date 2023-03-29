using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
  public  interface IAdminRepository
  {
    Task<Admin> GetAdmin(RequestData request);
    Task<Admin> GetAdminById(int id);
    Task<bool> RefreshToken(string refreshToken);
    Task<Admin> GetAdminByAdminName(string adminName);
    void SaveChanges();
  }
}
