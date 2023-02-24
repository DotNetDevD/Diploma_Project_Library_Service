using LibraryAggregator.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public class BooksLibraryRepository : BaseRepository<BooksLibrary>, IBooksLibraryRepository
    {
        public BooksLibraryRepository(LibraryDataBaseContext libraryDataBaseContext) : base(libraryDataBaseContext)
        {
        }

        public async Task<IEnumerable<BooksLibrary>> GetdLibraryListByBookIdAsync(int id)
        {
            return await dbSet.Include(u => u.Book)
                    .Include(u => u.Booking).ThenInclude(u => u.Client)
                    .Include(u => u.Booking).ThenInclude(u => u.BookingStatus)
                    .Include(l => l.Library)
                    .Where(b => b.BookId == id).ToListAsync();
        }
    }
}
