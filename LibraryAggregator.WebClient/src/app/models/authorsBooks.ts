import { Author } from "./author";
import { Book } from "./book";

export interface AuthorsBooks {
    authorsBooksId?: number;
    authorId?: number;
    bookId?: number;
    author?: Author;
    book?: Book;
}