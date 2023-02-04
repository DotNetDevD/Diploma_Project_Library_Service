import { Component } from '@angular/core';
import { AuthorApiService } from 'src/app/api-services/author-api.service';
import { Author } from 'src/app/models/author';

@Component({
  selector: 'app-author-info',
  templateUrl: './author-info.component.html',
  styleUrls: ['./author-info.component.css']
})
export class AuthorInfoComponent {
  authorList: Author[] = [];
  
  constructor(private readonly authorService: AuthorApiService) { }

  ngOnInit(): void {
    this.retrieveAuthorList();
  }

  retrieveAuthorList(): void {
    this.authorService.getAuthorList()
      .subscribe({
        next: (data) => {
          this.authorList = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }
}
