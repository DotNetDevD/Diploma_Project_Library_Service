import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { BookApiService } from 'src/app/api-services/book-api.service';

@Component({
  selector: 'app-book-show',
  templateUrl: './book-show.component.html',
  styleUrls: ['./book-show.component.css']
})
export class BookShowComponent implements OnInit {

  bookList$!: Observable<any>;

  constructor(private service: BookApiService) { }

  ngOnInit(): void {
    this.bookList$ = this.service.getBookList();
  }
}
