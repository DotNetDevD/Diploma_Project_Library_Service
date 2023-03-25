import { Component, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-nav-bar',
    templateUrl: './nav-bar.component.html',
    styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
    searchTerm = '';

    constructor(private readonly router: Router) { }

    ngOnInit() { }

    search() {
        if (!this.searchTerm.trim()) {
            return
        }
        this.router.navigate(['/search'], { queryParams: { query: this.searchTerm } })
        this.searchTerm = '';
    }
}