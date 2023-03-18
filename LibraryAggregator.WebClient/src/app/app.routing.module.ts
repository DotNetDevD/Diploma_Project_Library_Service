import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthorCardComponent } from "./author/author-card/author-card.component";
import { AuthorInfoComponent } from "./author/author-info/author-info.component";
import { AuthorComponent } from "./author/author.component";
import { AuthorBooksComponent } from "./book/author-books/author-books.component";
import { BookAvailableForBookingComponent } from "./book/book-available-for-booking/book-available-for-booking.component";
import { BookCardComponent } from "./book/book-card/book-card.component";
import { BookInfoComponent } from "./book/book-info/book-info.component";
import { BookComponent } from "./book/book.component";
import { BookingComponent } from "./book/booking/booking.component";
import { FoundBooksComponent } from "./book/found-books/found-books.component";
import { GenreShowComponent } from "./genre/genre-show/genre-show.component";
import { GenreComponent } from "./genre/genre.component";
import { LibraryCardComponent } from "./library/library-card/library-card.component";
import { LibraryInfoComponent } from "./library/library-info/library-info.component";
import { LibraryComponent } from "./library/library.component";
import { MainContentComponent } from "./main-content/main-content.component";
import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";
import { SearchComponent } from "./search/search.component";

const appRoutes: Routes = [

    { path: 'book', component: BookComponent },
    { path: 'book-info/:id', component: BookInfoComponent },
    { path: 'book-card', component: BookCardComponent },
    { path: 'found-books', component: FoundBooksComponent},
    { path: 'library', component: LibraryComponent },
    { path: 'library-info/:id', component: LibraryInfoComponent },
    { path: 'library-card', component: LibraryCardComponent },
    { path: 'author', component: AuthorComponent },
    { path: 'author-info/:id', component: AuthorInfoComponent },
    { path: 'booking/:id', component: BookingComponent },
    { path: 'author-card', component: AuthorCardComponent },
    { path: 'genre', component: GenreComponent },
    { path: 'genre-show/:id', component: GenreShowComponent },
    { path: 'author-books/:id', component: AuthorBooksComponent },
    { path: 'book-available-for-booking/:id', component: BookAvailableForBookingComponent },
    { path: 'index', component: MainContentComponent },
    { path: 'search', component: SearchComponent },
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
    
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})

export class AppRoutingModule {
}