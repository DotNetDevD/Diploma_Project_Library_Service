import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorShowComponent } from "./author/author-show/author-show.component";
import { BookShowComponent } from "./book/book-show/book-show.component";
import { GenreShowComponent } from "./genre/genre-show/genre-show.component";
import { LibraryCardComponent } from "./library/library-card/library-card.component";
import { LibraryInfoComponent } from "./library/library-info/library-info.component";
import { LibraryComponent } from "./library/library.component";
import { MainContentComponent } from "./main-content/main-content.component";
import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";

const appRoutes: Routes = [
    { path: 'book/book-show', component: BookShowComponent },
    { path: 'library', component: LibraryComponent },
    { path: 'library-info/:id', component: LibraryInfoComponent },
    { path: 'library-card', component: LibraryCardComponent },
    { path: 'author/author-show', component: AuthorShowComponent },
    { path: 'genre/genre-show', component: GenreShowComponent },
    { path: 'index', component: MainContentComponent },
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})

export class AppRoutingModule {
}