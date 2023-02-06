import { AuthorsBooks } from "./authorsBooks";
import { BookLibrary } from "./bookLibrary";
import { BooksGenres } from "./booksGenres";

export interface Book {
    bookId?: number;
    title?: string;
    isbn?: string;
    coverImgPath?: string;
    publishDate?: Date;
    description?: string;
    pageCount?: number;
    authorFullName?: string;
    authorsBooks: AuthorsBooks[];
    booksGenres: BooksGenres[];
    booksLibraries: BookLibrary[];
}