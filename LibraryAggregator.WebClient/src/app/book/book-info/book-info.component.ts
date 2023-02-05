import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { Genre } from 'src/app/models/genre';
import { BookVM } from 'src/app/models/bookVM';

@Component({
  selector: 'app-book-info',
  templateUrl: './book-info.component.html',
  styleUrls: ['./book-info.component.css']
})
export class BookInfoComponent {
  book: BookVM = {
    genreList: [],
    authorList: []
  };

  constructor(private readonly bookService: BookApiService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getTutorial(this.route.snapshot.params["id"]);
  }

  getTutorial(id: number): void {
    this.bookService.getBookById(id)
      .subscribe({
        next: (data) => {
          this.book = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}
