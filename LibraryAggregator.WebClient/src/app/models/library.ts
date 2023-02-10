import { imagesForCarousel } from "./imagesForCarousel";
export interface Library {
    libraryId?: any;
    name?: string;
    address?: string;
    phoneNumber?: string;
    email?: string;
    mapLink?: string;
    ageGroup?: string;
    directorPhotoLink?: string;
    shortDiscription?: string;
    coverImagePath?: string;
    url?: string;
    historyOfLibrary?: string;
    imagesForCarousel?: imagesForCarousel[];
}