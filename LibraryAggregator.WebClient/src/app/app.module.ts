import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { BookShowComponent } from './book/book-show/book-show.component';
import { BookAddEditComponent } from './book/book-add-edit/book-add-edit.component';
import { BookApiService } from './book-api.service';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { MainContentComponent } from './main-content/main-content.component';
import { TestComponent } from './test/test.component';
import { LibraryComponent } from './library/library.component';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const appRoutes: Routes = [
{path: 'library', component: LibraryComponent},
{path: 'library/test', component: TestComponent},
{path: 'index', component: MainContentComponent},
{path: 'test', component: TestComponent},
{path: '', redirectTo: '/index', pathMatch: 'full'},
{path: '**', component: PageNotFoundComponent}
];

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
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule, 
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,

    RouterModule.forRoot(appRoutes)
  ],
  providers: [BookApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
