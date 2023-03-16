import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GenreApiService } from '../api-services/genre-api.service';

@Component({
  selector: 'app-genre',
  templateUrl: './genre.component.html',
  styleUrls: ['./genre.component.css']
})
export class GenreComponent implements OnInit {
  genreList$!: Observable<any>;

  constructor(private service: GenreApiService) { }

  ngOnInit(): void {
    this.genreList$ = this.service.getGenreList();
  }
}
