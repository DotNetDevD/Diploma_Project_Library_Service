import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Login } from '../models/Login';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private BaseUrl: string = 'https://localhost:7091/api/' 
  constructor(private http: HttpClient) { }

  getAdmin(id: number): Observable<Login>{
    return this.http.get<Login>(this.BaseUrl + `Admin/${id}`)
  }
}
