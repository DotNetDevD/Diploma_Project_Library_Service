using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.Common.Interface
{
  public interface IAdminService
  {
    Task<LibraryAdmin> GetLibraryAdminByEmailAsync(string email);
  
  }
}
