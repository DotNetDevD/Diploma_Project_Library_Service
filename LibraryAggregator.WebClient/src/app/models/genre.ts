import { BooksGenres } from "./booksGenres";

export interface Genre {
    genreId?: number;
    type?: string;
    booksGenres?: BooksGenres[];
}