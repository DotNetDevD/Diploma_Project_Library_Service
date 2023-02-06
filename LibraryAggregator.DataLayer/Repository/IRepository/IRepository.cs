using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IRepository<T>
        where T : class
    {
        Task<List<T>> GetListAsync(); // получение всех объектов
        Task<T> GetByIdAsync(int id); // получение одного объекта по id
        Task CreateAsync(T item); // создание объекта
        Task UpdateAsync(int id); // обновление объекта
        Task DeleteAsync(int id); // удаление объекта по id
        Task SaveAsync();  // сохранение изменений
    }
}
