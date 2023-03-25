import { imagesForCarousel } from "./imagesForCarousel";
import { OperatingModes } from "./operatingModes";

export interface Library {
    libraryId?: any;
    name?: string;
    address?: string;
    phoneNumber?: string;
    site?: string;
    mapLink?: string;
    ageGroup?: string;
    directorPhotoLink?: string;
    shortDiscription?: string;
    coverImagePath?: string;
    url?: string;
    historyOfLibrary?: string;
    transport?: string;
    imagesForCarousel?: imagesForCarousel[];
    operatingModes?: OperatingModes;
}