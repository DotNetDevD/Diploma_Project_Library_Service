import { Book } from "./Book.model";
import { Genre } from "./Genre.model";
export interface BooksGenre{
    BookId:number;
    Book:Book;
    GenreId:number;
    Genre: Genre;
} 