import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { BookAddEditComponent } from './book/book-add-edit/book-add-edit.component';
import { BookApiService } from './api-services/book-api.service';
import { NavBarComponent } from './nav-bar/nav-bar.component';
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


registerLocaleData(localeRu);

@NgModule({
    declarations: [
        AppComponent,
        AuthorCardComponent,
        AuthorInfoComponent,
        AuthorComponent,
        AuthorPopularBooksComponent,
        BookComponent,
        BookAddEditComponent,
        BookCardComponent,
        BookInfoComponent,
        NavBarComponent,
        MainContentComponent,
        LibraryComponent,
        LibraryCardComponent,
        LibraryInfoComponent,
        PageNotFoundComponent,
        GenreShowComponent,
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
        { provide: LOCALE_ID, useValue: 'ru' }
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }
