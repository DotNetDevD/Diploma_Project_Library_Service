using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
  public  interface IAdminRepository
  {
    Task<Admin> GetAdmin(RequestLogin request);
  }
}
