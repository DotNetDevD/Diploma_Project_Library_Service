import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-book-info',
  templateUrl: './book-info.component.html',
  styleUrls: ['./book-info.component.css']
})
export class BookInfoComponent {
  bookList: Book = {};
  constructor(private readonly bookService: BookApiService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.getTutorial(this.route.snapshot.params["id"]);
    console.log(this.route.snapshot)
  }

  getTutorial(id: number): void {
    this.bookService.getBookById(id)
      .subscribe({
        next: (data) => {
          this.bookList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}
