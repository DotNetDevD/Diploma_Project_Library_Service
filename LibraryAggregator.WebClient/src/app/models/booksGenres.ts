import { Book } from "./book";
import { Genre } from "./genre";

export interface BooksGenres {
    booksGenresId?: number;
    bookId?: number;
    genreId?: number;
    book?: Book;
    genre?: Genre;
}