import { Component, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { LibraryApiService } from 'src/app/api-services/library-api.service';
import { Library } from 'src/app/models/library';

@Component({
    selector: 'app-library-info',
    templateUrl: './library-info.component.html',
    styleUrls: ['./library-info.component.css']
})
export class LibraryInfoComponent {
    
    library: Library = {};

    constructor(private readonly libraryService: LibraryApiService,
        private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.getTutorial(this.route.snapshot.params["id"]);
        console.log(this.route.snapshot)
    }

    getTutorial(id: number): void {
        this.libraryService.getLibraryById(id)
            .subscribe({
                next: (data) => {
                    this.library = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }
}
