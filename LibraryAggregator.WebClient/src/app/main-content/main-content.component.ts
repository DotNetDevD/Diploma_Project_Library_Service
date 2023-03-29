import { Component, OnInit } from '@angular/core';
import { BookApiService } from '../api-services/book-api.service';
import { Book } from '../models/book';

@Component({
    selector: 'app-main-content',
    templateUrl: './main-content.component.html',
    styleUrls: ['./main-content.component.css']
})
export class MainContentComponent implements OnInit {
    bookList: Book[] = [];

    constructor(private readonly bookService: BookApiService) { }
    ngOnInit(): void {
        this.retrievebookList();
    }

    retrievebookList(): void {
        this.bookService.getBookList()
            .subscribe({
                next: (data) => {
                    this.bookList = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }
}