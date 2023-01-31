import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookApiService {

  readonly bookAPIUrl = "https://localhost:7072/api";

  constructor(private http:HttpClient) { }

  getBookList():Observable<any[]> {
    return this.http.get<any>(this.bookAPIUrl + '/books');
  }
  addBook(data:any) {
    return this.http.post(this.bookAPIUrl + '/books', data);
  }
  updateBook(id:number|string, data:any) {
    return this.http.put(this.bookAPIUrl + `/books/${id}`, data);
  }
  deleteBook(id:number|string) {
    return this.http.delete(this.bookAPIUrl + `/books/${id}`);
  }
}
