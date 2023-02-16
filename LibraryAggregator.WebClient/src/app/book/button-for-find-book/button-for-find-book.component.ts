import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { SearchApiService } from 'src/app/api-services/search-api.service';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-button-for-find-book',
  templateUrl: './button-for-find-book.component.html',
  styleUrls: ['./button-for-find-book.component.css']
})
export class ButtonForFindBookComponent implements OnInit {
  bookList: Book[] = [];

  bookTitle = '';
  constructor(private readonly searchService :SearchApiService){}

  ngOnInit() {
    this.searchService.searchSomeBooks(this.bookTitle)
  }
  search(){
    if(!this.bookTitle.trim()){
      return 
    }

    this.searchService.searchSomeBooks(this.bookTitle)
      .subscribe({
        next: (data) => {
          this.bookList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
    
      this.bookTitle = '';
  }

}
