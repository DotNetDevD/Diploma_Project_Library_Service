import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthorApiService } from 'src/app/api-services/author-api.service';
import { Author } from 'src/app/models/author';

@Component({
	selector: 'app-author-info',
	templateUrl: './author-info.component.html',
	styleUrls: ['./author-info.component.css']
})
export class AuthorInfoComponent {
	author: Author = {
		authorsBooks: []
	};

	constructor(private readonly authorService: AuthorApiService,
		private route: ActivatedRoute) { }

	ngOnInit(): void {
		this.getTutorial(this.route.snapshot.params["id"]);
	}

	getTutorial(id: number): void {
		this.authorService.getAuthorById(id)
			.subscribe({
				next: (data) => {
					this.author = data;
					console.log(data);
				},
				error: (e) => console.error(e)
			});
	}
}
