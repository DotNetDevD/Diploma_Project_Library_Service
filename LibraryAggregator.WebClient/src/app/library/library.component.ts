import { Component, OnInit } from '@angular/core';
import { observable, Observable, tap } from 'rxjs';
import { LibraryApiService } from 'src/app/api-services/library-api.service';
import { Library } from '../models/library';

@Component({
    selector: 'app-library',
    templateUrl: './library.component.html',
    styleUrls: ['./library.component.css']
})
export class LibraryComponent implements OnInit {

    libraryList: Library[] = [];
    
    constructor(private readonly libraryService: LibraryApiService) { }

    ngOnInit(): void {
        this.retrievelibraryList();
    }
    
    retrievelibraryList(): void {
        this.libraryService.getLibraryList()
          .subscribe({
            next: (data) => {
              this.libraryList = data;
              console.log(data);
            },
            error: (e) => console.error(e)
          });
      }
}
