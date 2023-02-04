export interface Book{
  bookId?:number;
  title?:string;
  Isbn?:string;
  coverImgPath?:string;
  publishDate?:Date;
  description?:string;
  pageCount?:number;
  authorsBooks?:[];
  booksGenres?:[];
  booksLibraries?:[];
}