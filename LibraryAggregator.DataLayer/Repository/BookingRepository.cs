using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace LibraryAggregator.DataLayer.Repository
{
  public class BookingRepository : BaseRepository<Booking>, IBookingRepository
  {
    public BookingRepository(LibraryDataBaseContext _db) : base(_db)
    { 
    }

    public async Task<IEnumerable<Booking>> GetFullInfoBookingsAsync()
    {
      return await dbSet.Include(c => c.Client)
                        .Include(l => l.BooksLibrary).ThenInclude(l => l.Library)
                        .Include(l => l.BooksLibrary).ThenInclude(l => l.Book)
                        .ToListAsync();
    }

    public async Task<Booking> GetFullInfoBookingAsync(int id)
    {
      return await dbSet.Include(c => c.Client)
                        .Include(l => l.BooksLibrary).ThenInclude(l => l.Library)
                        .Include(l => l.BooksLibrary).ThenInclude(l => l.Book)
                        .FirstOrDefaultAsync(b => b.BookingId == id);
    }

    public async Task<IEnumerable<Booking>> GetFullBookingBooks()
    {
      return await dbSet.ToListAsync();
    }

    public async Task DeleteRecord(int id)
    {
      var booking = dbSet.Find(id);
      dbSet.Remove(booking);
      _db.SaveChanges();
    }
  }
}
