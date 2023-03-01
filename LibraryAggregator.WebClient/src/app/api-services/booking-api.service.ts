import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BookLibrary } from '../models/bookLibrary';
import { BookingDto } from '../models/Dtos/bookingDto';

@Injectable({
    providedIn: 'root'
})

export class BookingApiService {

    readonly APIUrl = "https://localhost:7072/api";

    constructor(private http: HttpClient) { }

    getAvailableBookingByBookId(id: number): Observable<BookLibrary[]> {
        return this.http.get<BookLibrary[]>(this.APIUrl + `/booking/book/${id}`);
    }

    addBooking(data: BookingDto) {
        return this.http.post(this.APIUrl + '/booking', data);
    }

    getBookLibraryById(id: number): Observable<BookLibrary> {
        return this.http.get<BookLibrary>(this.APIUrl + `/booking/bookLibrary/${id}`)
    }
}
