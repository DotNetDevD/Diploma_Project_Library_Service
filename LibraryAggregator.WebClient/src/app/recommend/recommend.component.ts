import { Component, OnInit } from '@angular/core';
import { BookApiService } from '../api-services/book-api.service';
import { Book } from '../models/book';

@Component({
  selector: 'app-recommend',
  templateUrl: './recommend.component.html',
  styleUrls: ['./recommend.component.css']
})
export class RecommendComponent implements OnInit {

  topDetectiveBooks: Book[] = [];
  topTechnicalBooks: Book[] = [];

  constructor(private readonly bookService: BookApiService) { }
  
  ngOnInit(): void {
    this.retrieveDetectiveBooks(6);
    this.retrieveTechnicalBooks(3);
  }

  retrieveDetectiveBooks(id: number): void {
    this.bookService.getBookListByGenreId(id)
      .subscribe({
        next: (data) => {
          this.topDetectiveBooks = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
  retrieveTechnicalBooks(id: number): void {
    this.bookService.getBookListByGenreId(id)
      .subscribe({
        next: (data) => {
          this.topTechnicalBooks = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}