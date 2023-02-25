import { Booking } from "./booking";

export interface Client {
    clientId: number;
    name?: string;
    surname?: string;
    email?: string;
    phoneNumber?: string;
    booking?: Booking[];
}