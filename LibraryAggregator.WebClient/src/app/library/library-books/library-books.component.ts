import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-library-books',
  templateUrl: './library-books.component.html',
  styleUrls: ['./library-books.component.css']
})
export class LibraryBooksComponent {
  books?: Book[] = [];

  constructor(private readonly bookService: BookApiService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getBooksInLibraryById(this.route.snapshot.params["id"]);
    console.log(this.route.snapshot)
  }

  getBooksInLibraryById(id: number): void {
    this.bookService.getBookListByLibraryId(id)
      .subscribe({
        next: (data) => {
          this.books = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}

