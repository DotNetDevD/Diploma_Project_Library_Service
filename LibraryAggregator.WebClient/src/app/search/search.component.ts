import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { SearchApiService } from '../api-services/search-api.service';
import { BookLibraryAuthor } from '../models/bookLibraryAuthor';

@Component({
    selector: 'app-search',
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
    bookLibraryAuthor?: BookLibraryAuthor;
    query: any;
    private querySubscription: Subscription = new Subscription;

    constructor(private readonly searchService: SearchApiService,
        private route: ActivatedRoute) {
            this.querySubscription = this.route.queryParams.subscribe(
                (queryParam: any) => {
                    this.query = queryParam['query'];
                }
            );
            this.searchBookLibraryAuthor(this.query)
    }
    ngOnChanges(): void{
        
    }
    ngOnInit(): void {
       
    }

    searchBookLibraryAuthor(input: string): void {
        this.searchService.searchBookLibraryAuthor(input)
            .subscribe({
                next: (data) => {
                    this.bookLibraryAuthor = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }
}