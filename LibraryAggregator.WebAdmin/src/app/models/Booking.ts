import { Status } from "./BookStatus";

export class Booking{
  bookingId?:number;
  code?:number;
  startDate?:Date;
  finishDate?:Date;
  booksLibraryId?:number;
  clientId?:number;
  bookingStatus?:Status;
}