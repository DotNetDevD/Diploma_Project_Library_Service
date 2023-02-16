import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models/book';

@Injectable({
  providedIn: 'root'
})
export class SearchApiService {

  readonly  apiUrl = "https://localhost:7072/api";

  constructor(private http: HttpClient) { }

  // SearchBooks
    searchSomeBooks(title: string): Observable<Book[]> {
      return this.http.get<Book[]>(this.apiUrl + `/search/${title}`);
  }
}
