import { BookingStatus } from "./bookingStatus";
import { BookLibrary } from "./bookLibrary";
import { Client } from "./client";

export interface Booking {
    bookingId?: number;
    code?: number;
    startDate: Date;
    finishDate: Date;
    clientId: number;
    client?: Client;
    booksLibraryId: number;
    booksLibrary?: BookLibrary;
    bookingStatusId?: number;
    bookingStatus?: BookingStatus;
}
