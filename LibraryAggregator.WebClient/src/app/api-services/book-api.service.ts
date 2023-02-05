import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models/book';
import { BookVM } from '../models/bookVM';

@Injectable({
  providedIn: 'root'
})
export class BookApiService {

  readonly APIUrl = "https://localhost:7072/api";

  constructor(private http:HttpClient) { }

  getBookList():Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/books');
  }
  getBookById(id: number): Observable<BookVM> {
    return this.http.get<BookVM>(this.APIUrl + `/books/${id}`)
  }
  addBook(data:any) {
    return this.http.post(this.APIUrl + '/book', data);
  }
  updateBook(id:number|string, data:any) {
    return this.http.put(this.APIUrl + `/books/${id}`, data);
  }
  deleteBook(id:number|string) {
    return this.http.delete(this.APIUrl + `/books/${id}`);
  }
}
