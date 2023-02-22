import { Component, Input, OnInit } from '@angular/core';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-found-books',
  templateUrl: './found-books.component.html',
  styleUrls: ['./found-books.component.css']
})
export class FoundBooksComponent implements OnInit{
  
  @Input() bookList: Book[] =[];

  ngOnInit(): void {
  }

}
