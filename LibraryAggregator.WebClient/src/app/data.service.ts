//import { Injectable } from '@angular/core';
//import { HttpClient } from '@angular/common/http';
//import { Author } from './Author'; // ?????????

//@Injectable()
//export class DataService {

//  private url = "/api/Author";

//  constructor(private http: HttpClient) {
//  }

//  getAuthors() {
//    return this.http.get(this.url);
//  }

//  getAuthor(id: number) {
//    return this.http.get(this.url + '/' + id);
//  }

//  createAuthor(author: Author) {
//    return this.http.post(this.url, author);
//  }
//  updateAuthor(author: Author) {

//    return this.http.put(this.url, author);
//  }
//  deleteAuthor(id: number) {
//    return this.http.delete(this.url + '/' + id);
//  }
//}
