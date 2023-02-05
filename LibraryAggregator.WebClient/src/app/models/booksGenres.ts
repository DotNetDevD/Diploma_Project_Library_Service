import { Book } from "./book";
import { Genre } from "./genre";

export interface BooksGenres{
  booksGenresId?:number;
  bookId?:number;
  genresId?:number;
  book?:Book;
  genre?:Genre;
}