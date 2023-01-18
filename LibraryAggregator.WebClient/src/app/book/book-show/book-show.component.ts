import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BookApiService } from 'src/app/book-api.service';

@Component({
  selector: 'app-book-show',
  templateUrl: './book-show.component.html',
  styleUrls: ['./book-show.component.css']
})
export class BookShowComponent implements OnInit  {

  bookList$!:Observable<any[]>;
  genreList$!:Observable<any[]>;
  genreList:any=[];

  // Map to display data associate with foreign keys
  genreMap:Map<number, string> = new Map()
  
  constructor(private service:BookApiService) { }
  
  ngOnInit(): void {
    this.bookList$ = this.service.getBookList();
  }
}
