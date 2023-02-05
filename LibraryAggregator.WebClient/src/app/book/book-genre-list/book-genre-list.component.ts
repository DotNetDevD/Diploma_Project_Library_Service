import { Component, Input } from '@angular/core';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-book-genre-list',
  templateUrl: './book-genre-list.component.html',
})
export class BookGenreListComponent {
  @Input()
  book!: Book;
}
