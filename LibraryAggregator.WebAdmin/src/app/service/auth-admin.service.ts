import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Login } from '../models/Login';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class AuthAdminService {

  BaseUrl:string = "https://localhost:7091/api/AdminAuth/"
  constructor(private http: HttpClient , private router:Router ) {}


  login(data: Login): Observable<Login>{
    console.log(data)
    return this.http.post<Login>(`${this.BaseUrl}authenticate`, data)
  }

  storeToken(tokenValue: string){
    localStorage.setItem('token',tokenValue)
  }

  getToken(){
    return localStorage.getItem('token')
  }

  isLoggedIn(): boolean{
    return !!localStorage.getItem('token')
  }

  singOut(){
    localStorage.clear();
    this.router.navigate(['login']);
  }

}
