import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { BookApiService } from './api-services/book-api.service';
import { MainContentComponent } from './main-content/main-content.component';
import { LibraryComponent } from './library/library.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AppRoutingModule } from './app.routing.module';
import { LibraryCardComponent } from './library/library-card/library-card.component';
import { LibraryApiService } from './api-services/library-api.service';
import { LibraryInfoComponent } from './library/library-info/library-info.component';
import { AuthorApiService } from './api-services/author-api.service';
import { GenreShowComponent } from './genre/genre-show/genre-show.component';
import { GenreApiService } from './api-services/genre-api.service';
import { BookCardComponent } from './book/book-card/book-card.component';
import { AuthorCardComponent } from './author/author-card/author-card.component';
import { AuthorInfoComponent } from './author/author-info/author-info.component';
import { AuthorComponent } from './author/author.component';
import { AuthorPopularBooksComponent } from './author/author-popular-books/author-popular-books.component';
import { registerLocaleData } from '@angular/common';
import localeRu from '@angular/common/locales/ru';
import { LOCALE_ID, NgModule } from '@angular/core';
import { BookInfoComponent } from './book/book-info/book-info.component';
import { FoundBooksComponent } from "./book/found-books/found-books.component";
import { SearchApiService } from './api-services/search-api.service';
import { SearchComponent } from './search/search.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { BookingApiService } from './api-services/booking-api.service';
import { BookAvailableForBookingComponent } from './book/book-available-for-booking/book-available-for-booking.component';
import { BookingComponent } from './book/booking/booking.component';
import { SuccessBookingComponent } from './book/success-booking/success-booking.component';
import { GenreComponent } from './genre/genre.component';

registerLocaleData(localeRu);

@NgModule({
    declarations: [
        AppComponent,
        AuthorCardComponent,
        AuthorInfoComponent,
        AuthorComponent,
        AuthorPopularBooksComponent,
        FoundBooksComponent,
        BookComponent,
        BookCardComponent,
        BookInfoComponent,
        MainContentComponent,
        LibraryComponent,
        LibraryCardComponent,
        LibraryInfoComponent,
        PageNotFoundComponent,
        GenreShowComponent,
        SearchComponent,
        NavBarComponent,
        BookAvailableForBookingComponent,
        BookingComponent,
        SuccessBookingComponent,
        GenreComponent,
    ],
    imports: [
        AppRoutingModule,
        BrowserModule,
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
    ],
    providers: [
        BookApiService,
        LibraryApiService,
        AuthorApiService,
        GenreApiService,
        SearchApiService,
        BookingApiService,
        { provide: LOCALE_ID, useValue: 'ru' }
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
