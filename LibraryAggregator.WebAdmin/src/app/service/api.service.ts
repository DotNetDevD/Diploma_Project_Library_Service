import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Login } from '../models/Login';
import { Observable } from 'rxjs';
import { Booking } from '../models/Booking';
import { BookingDto } from '../models/BookingDto';
import { BookLibrary } from '../models/BookLibrary';
import { LibraryDto } from '../models/LibraryDto';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private BaseUrl: string = 'https://localhost:7091/api/' 
  constructor(private http: HttpClient) { }

  getAdmin(id: number): Observable<Login>{
    return this.http.get<Login>(this.BaseUrl + `Admin/${id}`)
  }

  getLibrary(id:number) {
    return this.http.get<LibraryDto[]>(this.BaseUrl + `Admin/Library?id=${id}`)
  }

  getBookingBooks(){
    return this.http.get<Booking[]>(this.BaseUrl +`Admin/BooksBooking`)
  }

  addBooking(data: BookingDto) {
    return this.http.post(this.BaseUrl + 'booking', data);
  }
}
