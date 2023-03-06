using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
  public interface IAdminRepository : IRepository<LibraryAdmin> 
  {
    Task<LibraryAdmin> GetLibraryAdminByEmail(string email);
  }
}
