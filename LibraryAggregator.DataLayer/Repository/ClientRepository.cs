using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(LibraryDataBaseContext libraryDataBaseContext) : base(libraryDataBaseContext)
        {
        }

        public async Task<Client> GetFullInfoClientAsync(int id)
        {
            return await dbSet.Include(b => b.Booking)
                    .FirstOrDefaultAsync(i => i.ClientId == id);
        }

        public async Task<IEnumerable<Client>> GetFullInfoClientsAsync()
        {
            return await dbSet.Include(b => b.Booking).ToListAsync();
        }
    }
}
