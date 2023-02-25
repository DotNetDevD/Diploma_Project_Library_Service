import { Book } from "./book";
import { Booking } from "./booking";
import { Library } from "./library";

export interface BookLibrary {
    booksLibrariesId?: number;
    bookId?: number;
    libraryId?: number;
    count?: number;
    book?: Book;
    library?: Library;
    booking?: Booking[];
}