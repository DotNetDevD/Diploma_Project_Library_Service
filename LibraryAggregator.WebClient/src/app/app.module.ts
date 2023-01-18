import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { BookShowComponent } from './book/book-show/book-show.component';
import { BookAddEditComponent } from './book/book-add-edit/book-add-edit.component';
import { BookApiService } from './book-api.service';

@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    BookShowComponent,
    BookAddEditComponent
  ],
  imports: [
    BrowserModule, 
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [BookApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
