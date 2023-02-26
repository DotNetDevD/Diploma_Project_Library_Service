import { Book } from "./book";
import { Booking } from "./booking";
import { Library } from "./library";

export interface BookLibrary {
    booksLibrariesId?: number;
    bookId?: number;
    libraryId?: number;
    count?: number;
    bookedBook?: number;
    freeBook?: number;
    isFreeBook?: boolean;
    book?: Book;
    library?: Library;
    booking?: Booking[];
}