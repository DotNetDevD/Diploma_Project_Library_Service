import { Author } from "./author";
import { Genre } from "./genre";

export interface BookVM {
    bookId?: number;
    title?: string;
    isbn?: string;
    coverImgPath?: string;
    publishDate?: Date;
    description?: string;
    pageCount?: number;
    authorFullName?: string;
    genreList: Genre [];
    authorList: Author [];
}