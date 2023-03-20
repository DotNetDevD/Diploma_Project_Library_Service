import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private BaseUrl: string = 'https://localhost:7091/api/Admin/Admin' 
  constructor(private http: HttpClient) { }

  getAdmin(number:number){
    return this.http.get<any>(this.BaseUrl)
  }
}
