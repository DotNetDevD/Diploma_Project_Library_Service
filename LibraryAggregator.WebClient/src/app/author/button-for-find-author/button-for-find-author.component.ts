import { Component, OnInit, Output } from '@angular/core';
import { SearchApiService } from 'src/app/api-services/search-api.service';
import { Author } from 'src/app/models/author';

@Component({
  selector: 'app-button-for-find-author',
  templateUrl: './button-for-find-author.component.html',
  styleUrls: ['./button-for-find-author.component.css']
})
export class ButtonForFindAuthorComponent implements OnInit{
  @Output()
  authorList: Author[] = [];

  partAuthorName = '';
  constructor(private readonly searchService: SearchApiService){ }

  ngOnInit() {
    this.searchService.searchSomeAuthors(this.partAuthorName)
  }
  search(){
    if(!this.partAuthorName.trim()){
      return 
    }
    this.searchService.searchSomeAuthors(this.partAuthorName)
      .subscribe({
        next: (data) => {
          this.authorList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
    
      this.partAuthorName = '';
  }
}
