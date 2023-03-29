import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { SearchApiService } from '../api-services/search-api.service';
import { AllEntity } from '../models/allEntity';

@Component({
    selector: 'app-search',
    templateUrl: './search.component.html',
    styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
    bookLibraryAuthor?: AllEntity;
    query: any;
    private querySubscription: Subscription = new Subscription;

    constructor(private readonly searchService: SearchApiService,
        private route: ActivatedRoute) {
    }

    ngOnInit(): void {
        this.querySubscription = this.route.queryParams.subscribe(
            (queryParam: any) => {
                this.query = queryParam['query'];
                this.search(this.query)
            }
        );
    }

    search(input: string): void {
        this.searchService.globalSearch(input)
            .subscribe({
                next: (data) => {
                    this.bookLibraryAuthor = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }
}