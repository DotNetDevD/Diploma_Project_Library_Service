import { Author } from "./author";
import { Book } from "./book";
import { Library } from "./library";

export interface AllEntity {
    books?: Book[];
    authors?: Author[];
    libraries?: Library[];
}
