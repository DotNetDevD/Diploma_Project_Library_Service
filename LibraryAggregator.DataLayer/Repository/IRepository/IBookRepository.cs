using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetAllFullInfoBookAsync(int id);
        Task<List<Book>> GetAllFullInfoBooksAsync();
    }
}
