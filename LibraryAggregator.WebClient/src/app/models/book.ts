export interface Book{
  bookId?:number;
  title?:string;
  isbn?:string;
  coverImgPath?:string;
  publishDate?:Date;
  description?:string;
  pageCount?:number;
  authorFullName?:string;
  authorsBooks?:[];
  booksGenres?:[];
  booksLibraries?:[];
}