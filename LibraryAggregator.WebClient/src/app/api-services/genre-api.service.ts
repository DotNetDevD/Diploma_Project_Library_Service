import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GenreApiService {

  readonly APIUrl = "https://localhost:7072/api";

  constructor(private http:HttpClient) { }
  
  // Genre
  getGenreList():Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/genres');
  }
  addGenre(data:any) {
    return this.http.post(this.APIUrl + '/genres', data);
  }
  updateGenre(id:number|string, data:any) {
    return this.http.put(this.APIUrl + `/genres/${id}`, data);
  }
  deleteGenre(id:number|string) {
    return this.http.delete(this.APIUrl + `/genres/${id}`);
  }
}
