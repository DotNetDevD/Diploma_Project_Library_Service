import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LibraryApiService {

  readonly APIUrl = "https://localhost:7072/api";

  constructor(private http: HttpClient) { }

  // Library
  getLibraryList(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/library');
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
