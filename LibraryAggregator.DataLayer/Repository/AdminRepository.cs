using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
  public class AdminRepository : BaseRepository<LibraryAdmin>, IAdminRepository
  {
    public AdminRepository(LibraryDataBaseContext libraryDataBaseContext) : base(libraryDataBaseContext)
    {
    }

    public async  Task<LibraryAdmin> GetLibraryAdminByEmail(string email)
    {
      return await dbSet.Where(item => item.Email == email).FirstOrDefaultAsync(); 
    }
  }
}
