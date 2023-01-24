using LibraryAggregator.DataLayer.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected LibraryDataBaseContext _db { get; set; }
        protected DbSet<T> dbSet;

        public BaseRepository(LibraryDataBaseContext libraryDataBaseContext)
        {
            _db = libraryDataBaseContext;
            dbSet = _db.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public async Task CreateAsync(T item)
        {
            dbSet.Add(item);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            dbSet.Remove(dbSet.Find(id)); 
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            dbSet.Entry(dbSet.Find(id)).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
