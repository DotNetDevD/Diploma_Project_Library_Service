﻿using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.Common.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUrlProviderService _urlProviderService;
        public BookService(IBookRepository bookRepository, IUrlProviderService urlProviderService)
        {
            _bookRepository = bookRepository;
            _urlProviderService = urlProviderService;
        }

        public async Task<IEnumerable<Book>> GetBooksListAsync()
        {
            IEnumerable<Book> books = await _bookRepository.GetFullInfoBooksAsync();
            foreach (var book in books)
            {
                book.Url = _urlProviderService.ConcatHostUrl(book.CoverImgPath);
            }    
            return books;
        }

        public async Task<IEnumerable<Book>> GetBooksListByGenreAsync(int genreId)
        {
            var books = await _bookRepository.GetFullInfoBooksAsync();
            var result = new List<Book>();
            foreach (var book in books)
            {
                book.Url = _urlProviderService.ConcatHostUrl(book.CoverImgPath);
                foreach (var g in book.BooksGenres)
                {
                    if (g.GenreId == genreId)
                    {
                        result.Add(book);
                        break;
                    }
                }
            }
            return result;
        }

        public async Task<IEnumerable<Book>> GetBookListByAuthorIdAsync(int authorId)
        {
            var books = await _bookRepository.GetFullInfoBooksAsync();
            var result = new List<Book>();
            foreach (var book in books)
            {
                book.Url = _urlProviderService.ConcatHostUrl(book.CoverImgPath);
                foreach (var a in book.AuthorsBooks)
                {
                    if (a.AuthorId == authorId)
                    {
                        result.Add(book);
                        break;
                    }
                }
            }
            return result;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            Book book = await _bookRepository.GetFullInfoBookAsync(id);
            book.Url = _urlProviderService.ConcatHostUrl(book.CoverImgPath);
            return book;
        }

        public async Task CreateBookAsync(Book book)
        {
            await _bookRepository.CreateAsync(book);
        }

        public async Task UpdateBookAsync(int id)
        {
            await _bookRepository.UpdateAsync(id);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _bookRepository.DeleteAsync(id);
        }       
    }
}

