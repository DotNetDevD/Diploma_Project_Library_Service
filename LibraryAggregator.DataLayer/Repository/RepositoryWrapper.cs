using LibraryAggregator.DataLayer.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private LibraryDataBaseContext _context;
        private IAuthorRepository? _author;
        private IBookRepository? _book;
        private IGenreRepository? _genre;


        public RepositoryWrapper(LibraryDataBaseContext context)
        {
            _context = context;
        }
        public IAuthorRepository Author
        {
            get
            {
                if(_author == null)
                {
                    return _author = new AuthorRepository(_context);
                }
                return _author;
            }
        }

        public IBookRepository Book
        {
            get
            {
                if(_book == null)
                {
                    return _book = new BookRepository(_context);
                }
                return _book;
            }
        }

        public IGenreRepository Genre
        {
            get
            {
                if(_genre == null)
                {
                    return _genre = new GenreRepository(_context);
                }
                return _genre;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
