import { Component, Input, OnInit } from '@angular/core';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-button-for-find-book',
  templateUrl: './button-for-find-book.component.html',
  styleUrls: ['./button-for-find-book.component.css']
})
export class ButtonForFindBookComponent implements OnInit {
  bookList: Book[] = [];
  constructor(){}

  ngOnInit(): void {
    
  }

}
