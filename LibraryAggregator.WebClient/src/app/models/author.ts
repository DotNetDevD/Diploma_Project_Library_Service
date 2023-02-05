import { AuthorsBooks } from "./authorsBooks";

export interface Author {
    authorId?: number;
    firstName?: string;
    lastName?: string;
    middleName?: string;
    dateOfBirth?: Date;
    coverImg?: string;
    biography?: string;
    authorsBooks: AuthorsBooks[];
}