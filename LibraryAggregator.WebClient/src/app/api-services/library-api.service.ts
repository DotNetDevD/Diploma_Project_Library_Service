import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Library } from '../models/library';

@Injectable({
  providedIn: 'root'
})
export class LibraryApiService {

  readonly APIUrl = "https://localhost:7072/api";

  constructor(private http: HttpClient) { }

  // Library
  getLibraryList(): Observable<Library[]> {
    return this.http.get<Library[]>(this.APIUrl + '/library');
  }
  getLibraryById(id: number): Observable<Library> {
    return this.http.get<Library>(this.APIUrl + `/library${id}`)
  }
  addLibrary(data: any) {
    return this.http.post(this.APIUrl + '/library', data);
  }
  updateLibrary(id: number | string, data: any) {
    return this.http.put(this.APIUrl + `/library${id}`, data);
  }
  deleteLibrary(id: number | string) {
    return this.http.delete(this.APIUrl + `/library${id}`);
  }
}
