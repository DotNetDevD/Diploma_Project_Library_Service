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
        public async Task<T> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetList()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }
        public async void Create(T item)
        {
            dbSet.Add(item);
            await _db.SaveChangesAsync();
        }
        public async void Delete(int id)
        {
            dbSet.Remove(dbSet.Find(id)); 
            // нужно ли проверять на null?
            await _db.SaveChangesAsync();
        }
        public async void Update(int id)
        {
            dbSet.Entry(dbSet.Find(id)).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public async void Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
