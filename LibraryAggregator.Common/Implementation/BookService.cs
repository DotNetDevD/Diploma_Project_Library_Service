﻿using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Repository.IRepository;
using LibraryAggregator.DataLayer.ViewModel;

namespace LibraryAggregator.Common.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetBooksListAsync()
        {
            return await _bookRepository.GetAllFullInfoBooksAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.GetAllFullInfoBookAsync(id);
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

        public async Task<IEnumerable<BookVM>> GetInfoForBookVM()
        {
            List<Book> books = await _bookRepository.GetAllFullInfoBooksAsync();
            List<BookVM> listBookVM = new();

            foreach (var item in books)
            {
                BookVM bookForVM = new BookVM
                {
                    BookId = item.BookId,
                    Isbn = item.Isbn,
                    Title = item.Title,
                    PageCount = item.PageCount,
                    PublishDate = item.PublishDate,
                    CoverImgPath = item.CoverImgPath,
                    Description = item.Description
                };
                foreach (var autor in item.AuthorsBooks)
                {
                    bookForVM.AuthorList.Add(autor.Author);
                }
                foreach (var genre in item.BooksGenres)
                {
                    bookForVM.GenreList.Add(genre.Genre);
                }
                listBookVM.Add(bookForVM);
            }

            return listBookVM;
        }
        public async Task<BookVM> GetInfoForBookVM(int id)
        {
            Book book = await _bookRepository.GetAllFullInfoBookAsync(id);

            BookVM bookForVM = new BookVM
            {
                BookId = book.BookId,
                Isbn = book.Isbn,
                Title = book.Title,
                PageCount = book.PageCount,
                PublishDate = book.PublishDate,
                CoverImgPath = book.CoverImgPath,
                Description = book.Description
            };
            foreach (var autor in book.AuthorsBooks)
            {
                bookForVM.AuthorList.Add(autor.Author);
            }
            foreach (var genre in book.BooksGenres)
            {
                bookForVM.GenreList.Add(genre.Genre);
            }

            return bookForVM;
        }
    }
}

