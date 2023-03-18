import { Component } from '@angular/core';
import { AuthorApiService } from '../api-services/author-api.service';
import { Author } from '../models/author';

@Component({
    selector: 'app-author',
    templateUrl: './author.component.html',
    styleUrls: ['./author.component.css']
})
export class AuthorComponent {
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
