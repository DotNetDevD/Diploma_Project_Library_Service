import { Component, OnInit, Output } from '@angular/core';
import { SearchApiService } from 'src/app/api-services/search-api.service';
import { Library } from 'src/app/models/library';

@Component({
  selector: 'app-button-for-find-library',
  templateUrl: './button-for-find-library.component.html',
  styleUrls: ['./button-for-find-library.component.css']
})
export class ButtonForFindLibraryComponent implements OnInit{
  @Output()
  libraryList: Library[] = [];

  name = '';
  constructor(private readonly searchService: SearchApiService){ }

  ngOnInit() {
    this.searchService.searchLibrary(this.name)
  }
  search(){
    if(!this.name.trim()){
      return 
    }
    this.searchService.searchLibrary(this.name)
      .subscribe({
        next: (data) => {
          this.libraryList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
    
      this.name = '';
  }
}
