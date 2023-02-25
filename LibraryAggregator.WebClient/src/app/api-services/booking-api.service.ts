import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Booking } from '../models/booking';
import { BookLibrary } from '../models/bookLibrary';

@Injectable({
    providedIn: 'root'
})
export class BookingApiService {

    readonly APIUrl = "https://localhost:7072/api";

    constructor(private http: HttpClient) { }

    getBookingList(): Observable<Booking[]> {
        return this.http.get<Booking[]>(this.APIUrl + '/booking');
    }
    getBookingById(id: number): Observable<Booking> {
        return this.http.get<Booking>(this.APIUrl + `/booking/${id}`)
    }
    GetAvailableBookingByBookId(id: number): Observable<BookLibrary> {
      return this.http.get<BookLibrary>(this.APIUrl + `/booking/book/${id}`)
  }
    addBooking(data: any) {
        return this.http.post(this.APIUrl + '/booking', data);
    }
    updateBooking(id: number | string, data: any) {
        return this.http.put(this.APIUrl + `/booking/${id}`, data);
    }
    deleteBooking(id: number | string) {
        return this.http.delete(this.APIUrl + `/booking/${id}`);
    }
}
