import { BookLibrary } from "./BookLibrary";


export interface Book {
  bookId?: number;
  title?: string;
  isbn?: string;
  coverImgPath?: string;
  url?: string;
  publishDate?: Date;
  description?: string;
  pageCount?: number;
  authorFullName?: string;
  booksLibraries: BookLibrary[];
}