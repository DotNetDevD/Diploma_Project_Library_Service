using LibraryAggregator.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> GetAllFullInfoBooksAsync();
    }
}
