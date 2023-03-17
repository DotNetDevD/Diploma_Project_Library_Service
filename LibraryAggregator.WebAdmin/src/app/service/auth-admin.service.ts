import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class AuthAdminService {

  BaseUrl:string = "https://localhost:7091/api/AdminAuth/"
  constructor(private http: HttpClient ) {}


  login(data : any){
    return this.http.post<any>(`${this.BaseUrl}authenticate`, data)
  }
}
