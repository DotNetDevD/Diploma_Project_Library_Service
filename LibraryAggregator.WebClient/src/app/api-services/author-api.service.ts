import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorApiService {

  readonly APIUrl = "https://localhost:7072/api";

  constructor(private http:HttpClient) { }

  // Authors
  getAuthorList():Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/author');
  }
  addAuthor(data:any) {
    return this.http.post(this.APIUrl + '/author', data);
  }
  updateAuthor(id:number|string, data:any) {
    return this.http.put(this.APIUrl + `/author/${id}`, data);
  }
  deleteAuthor(id:number|string) {
    return this.http.delete(this.APIUrl + `/author/${id}`);
  }
}
