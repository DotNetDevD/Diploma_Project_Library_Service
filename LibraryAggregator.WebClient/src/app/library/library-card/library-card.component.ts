import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { LibraryApiService } from 'src/app/api-services/library-api.service';

@Component({
  selector: 'app-library-card',
  templateUrl: './library-card.component.html',
  styleUrls: ['./library-card.component.css']
})
export class LibraryCardComponent implements OnInit {

  libraryList$!: Observable<any>;
  genreList$!: Observable<any>;
  // genreList: any = [];

  // Map to display data associate with foreign keys
  genreMap: Map<number, string> = new Map()

  constructor(private service: LibraryApiService) { }

  ngOnInit(): void {
    this.libraryList$ = this.service.getLibraryList();
  }
}
