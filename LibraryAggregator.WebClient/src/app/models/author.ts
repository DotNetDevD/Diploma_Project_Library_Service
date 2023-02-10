import { AuthorsBooks } from "./authorsBooks";

export interface Author {
    authorId?: number;
    firstName?: string;
    lastName?: string;
    middleName?: string;
    dateOfBirth?: Date;
    coverImgPath?: string;
    url?: string;
    biography?: string;
    authorsBooks: AuthorsBooks[];
}