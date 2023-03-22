import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Login } from '../models/Login';
import { Router } from '@angular/router';
import{ JwtHelperService } from '@auth0/angular-jwt'
@Injectable({
  providedIn: 'root'
})
export class AuthAdminService {

  private BaseUrl:string = "https://localhost:7091/api/AdminAuth/";
  private adminPayload:any;
  constructor(private http: HttpClient , private router:Router ) {
    this.adminPayload = this.decodedToken();
  }


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

  decodedToken(){
    const jwtHelper = new JwtHelperService();
    const token = this.getToken()!; 
    console.log(jwtHelper.decodeToken(token));
    return jwtHelper.decodeToken(token);
  }

  getAdminNameFromToken(){
    if(this.adminPayload)
      return this.adminPayload.unique_name;
  }
}
