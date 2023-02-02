import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { BookShowComponent } from './book/book-show/book-show.component';
import { BookAddEditComponent } from './book/book-add-edit/book-add-edit.component';
import { BookApiService } from './api-services/book-api.service';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { MainContentComponent } from './main-content/main-content.component';
import { TestComponent } from './test/test.component';
import { LibraryComponent } from './library/library.component';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AppRoutingModule } from './app.routing.module';
import { LibraryCardComponent } from './library/library-card/library-card.component';
import { LibraryApiService } from './api-services/library-api.service';
import { LibraryInfoComponent } from './library/library-info/library-info.component';
import { AuthorShowComponent } from './author/author-show/author-show.component';
import { AuthorApiService } from './api-services/author-api.service';
import { GenreShowComponent } from './genre/genre-show/genre-show.component';
import { GenreComponent } from './genre/genre.component';
import { GenreApiService } from './api-services/genre-api.service';


@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    BookShowComponent,
    BookAddEditComponent,
    NavBarComponent,
    MainContentComponent,
    TestComponent,
    LibraryComponent,
    LibraryCardComponent,
    LibraryInfoComponent,
    PageNotFoundComponent,
    AuthorShowComponent,
    GenreShowComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,


  ],
  providers: [BookApiService , LibraryApiService , AuthorApiService , GenreApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
