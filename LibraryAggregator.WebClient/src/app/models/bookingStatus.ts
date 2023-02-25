import { Booking } from "./booking";

export interface BookingStatus {
    bookingStatusId?: number;
    statusName?: string;
    statusDerscription?: string;
    booking?: Booking[];
}