import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Login } from '../models/Login';
@Injectable({
  providedIn: 'root'
})
export class AuthAdminService {

  BaseUrl:string = "https://localhost:7091/api/AdminAuth/"
  constructor(private http: HttpClient ) {}


  login(data: Login): Observable<Login>{
    console.log(data)
    return this.http.post<Login>(`${this.BaseUrl}authenticate`, data)
  }
}
