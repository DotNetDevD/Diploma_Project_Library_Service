using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public  interface IRepositoryWrapper
    {
        public IAuthorRepository Author { get;}
        public IBookRepository Book { get; }
        public IGenreRepository Genre { get; }
        void Save();
    }
}
