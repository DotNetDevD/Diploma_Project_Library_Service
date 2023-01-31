import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookApiService {

  readonly bookAPIUrl = "https://localhost:7072/api";

  constructor(private http:HttpClient) { }

  // Authors
  getAuthorList():Observable<any[]> {
    return this.http.get<any>(this.bookAPIUrl + '/author');
  }
  addAuthor(data:any) {
    return this.http.post(this.bookAPIUrl + '/author', data);
  }
  updateAuthor(id:number|string, data:any) {
    return this.http.put(this.bookAPIUrl + `/author/${id}`, data);
  }
  deleteAuthor(id:number|string) {
    return this.http.delete(this.bookAPIUrl + `/author/${id}`);
  }
}
