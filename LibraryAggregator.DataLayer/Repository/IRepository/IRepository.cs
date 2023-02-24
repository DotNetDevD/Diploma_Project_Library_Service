namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T item); 
        Task UpdateAsync(int id); 
        Task DeleteAsync(int id); 
        Task SaveAsync();  
    }
}
