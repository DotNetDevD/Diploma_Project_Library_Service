import { Component, OnInit } from '@angular/core';
import { observable, Observable, tap } from 'rxjs';
import { LibraryApiService } from 'src/app/api-services/library-api.service';

@Component({
    selector: 'app-library',
    templateUrl: './library.component.html',
    styleUrls: ['./library.component.css']
})
export class LibraryComponent implements OnInit {

    libraryList$!: Observable<any>;

    constructor(private readonly libraryService: LibraryApiService) { }

    ngOnInit(): void {
        this.libraryList$ = this.libraryService.getLibraryList();
    }
}
