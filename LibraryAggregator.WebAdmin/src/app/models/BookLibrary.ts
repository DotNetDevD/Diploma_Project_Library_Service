import { Book } from "./Book";
import { Booking } from "./Booking";
import { Library } from "./Library";

export interface BookLibrary {
  booksLibrariesId?: number;
  bookId?: number;
  libraryId?: number;
  count?: number;
  bookedBook?: number;
  freeBook?: number;
  isFreeBook?: boolean;
  title:string;
  book?: Book;
  library?: Library;
  booking?: Booking[];
}