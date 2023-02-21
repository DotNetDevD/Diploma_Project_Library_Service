import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Author } from '../models/author';
import { Book } from '../models/book';
import { Library } from '../models/library';

@Injectable({
    providedIn: 'root'
})
export class SearchApiService {

    readonly apiUrl = "https://localhost:7072/api";

    constructor(private http: HttpClient) { }

    // SearchBooks
    searchSomeBooks(title: string): Observable<Book[]> {
        return this.http.get<Book[]>(this.apiUrl + `/search/${title}`);
    }

    // SearchAuthors
    searchSomeAuthors(partName: string): Observable<Author[]> {
        return this.http.get<Author[]>(this.apiUrl + `/search/author/${partName}`);
    }

    // SearchLibrary
    searchLibrary(name: string): Observable<Library[]> {
        return this.http.get<Library[]>(this.apiUrl + `/search/library/${name}`);
    }
}
