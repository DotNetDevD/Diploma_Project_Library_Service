import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-author-books',
  templateUrl: './author-books.component.html',
  styleUrls: ['./author-books.component.css']
})
export class AuthorBooksComponent implements OnInit {

  authorbookList: Book[] = [];

  constructor(private readonly bookService: BookApiService,
    private route: ActivatedRoute) { }
  
  ngOnInit(): void {
    this.retrieveAuthorBooksList(this.route.snapshot.params["id"]);
  }

  retrieveAuthorBooksList(id: number): void {
    this.bookService.getBookListByAuthorId(id)
      .subscribe({
        next: (data) => {
          this.authorbookList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}