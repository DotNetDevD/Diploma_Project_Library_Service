import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { Book } from 'src/app/models/book';

@Component({
  selector: 'app-genre-show',
  templateUrl: './genre-show.component.html',
  styleUrls: ['./genre-show.component.css']
})
export class GenreShowComponent implements OnInit {

  bookGenreList: Book[] = [];

  constructor(private readonly bookService: BookApiService,
    private route: ActivatedRoute) { }
  
  ngOnInit(): void {
    this.retrievebBookGenreList(this.route.snapshot.params["id"]);
  }

  retrievebBookGenreList(id: number): void {
    this.bookService.getBookListByGenreId(id)
      .subscribe({
        next: (data) => {
          this.bookGenreList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}