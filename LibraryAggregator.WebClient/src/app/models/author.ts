import { AuthorsBooks } from "./authorsBook";

export interface Author{
     authorId?:number;
     firstName?:string;
     lastName?:string;
     MiddleName?:string;
     DateOfBirth?:Date;
     CoverImg?:string;
     Biography?:string;
     AuthorsBook?:AuthorsBooks[];
}