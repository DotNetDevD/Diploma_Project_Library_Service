import { Component, OnInit } from '@angular/core';
import { BookApiService } from '../api-services/book-api.service';
import { Book } from '../models/book';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit{
  bookList: Book[] = [];

  constructor(private readonly bookService: BookApiService) { }
  ngOnInit(): void {
    this.retrievebookList();
  }

  retrievebookList(): void {
    this.bookService.getBookList()
      .subscribe({
        next: (data) => {
          this.bookList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }



}
