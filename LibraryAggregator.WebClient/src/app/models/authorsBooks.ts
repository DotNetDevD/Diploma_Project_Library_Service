import { Author } from "./author";
import { Book } from "./book";

export interface AuthorsBooks {
    AuthorsBooksId?: number;
    AuthorId?: number;
    BookId?: number;
    Author?: Author;
    Book?: Book;
}