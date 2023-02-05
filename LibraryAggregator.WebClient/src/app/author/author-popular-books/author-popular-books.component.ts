import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-author-popular-books',
    templateUrl: './author-popular-books.component.html',
    styleUrls: ['./author-popular-books.component.css']
})
export class AuthorPopularBooksComponent {

    @Input()
    authorBook!: any;
}
