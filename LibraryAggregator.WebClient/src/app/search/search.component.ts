import { Component, Input, OnInit } from '@angular/core';
import { BookLibraryAuthor } from '../models/bookLibraryAuthor';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  @Input()
  bookLibraryAuthor?: BookLibraryAuthor;
}