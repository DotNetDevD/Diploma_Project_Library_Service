import { Component, OnInit } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { AuthorApiService } from 'src/app/api-services/author-api.service';

@Component({
  selector: 'app-author-show',
  templateUrl: './author-show.component.html',
  styleUrls: ['./author-show.component.css']
})
export class AuthorShowComponent  implements OnInit{
  authorList$!: Observable<any>;

  constructor(private service: AuthorApiService){
    
  }
  ngOnInit(): void {
      this.authorList$ = this.service.getAuthorList();
  }

}
