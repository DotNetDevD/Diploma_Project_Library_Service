import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { GenreApiService } from 'src/app/api-services/genre-api.service';

@Component({
  selector: 'app-genre-show',
  templateUrl: './genre-show.component.html',
  styleUrls: ['./genre-show.component.css']
})
export class GenreShowComponent implements OnInit {
  genreList$!: Observable<any>;

  constructor(private service: GenreApiService) { }

  ngOnInit(): void {
    this.genreList$ = this.service.getGenreList();
  }
}
