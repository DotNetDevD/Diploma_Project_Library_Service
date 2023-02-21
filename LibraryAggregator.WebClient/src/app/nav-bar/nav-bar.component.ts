import { Component, OnInit, Output } from '@angular/core';
import { SearchApiService } from '../api-services/search-api.service';
import { BookLibraryAuthor } from '../models/bookLibraryAuthor';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit{
  @Output()
  bookLibraryAuthor?: BookLibraryAuthor;

  name = '';
  constructor(private readonly searchService: SearchApiService){ }

  ngOnInit() {
    this.searchService.searchBookLibraryAuthor(this.name)
  }
  search(){
    if(!this.name.trim()){
      return 
    }
    this.searchService.searchBookLibraryAuthor(this.name)
      .subscribe({
        next: (data) => {
          this.bookLibraryAuthor = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
    
      this.name = '';
  }
}