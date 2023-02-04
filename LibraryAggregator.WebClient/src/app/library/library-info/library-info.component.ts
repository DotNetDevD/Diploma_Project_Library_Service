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
    data = [
        { img: "http://content.onliner.by/news/2014/07/default/7fb79907ab333a5679b1fecde955f22d.jpg", title: "Slide 1" },
        { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img2.jpg", title: "Slide 2" },
        { img: "https://therichpost.com/wp-content/uploads/2021/05/bootstrap5-carousel-slider-img3.jpg", title: "Slide 3" }
    ];
    library: Library = {};
    constructor(private readonly libraryService: LibraryApiService,
        private route: ActivatedRoute,
        private router: Router) { }

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
