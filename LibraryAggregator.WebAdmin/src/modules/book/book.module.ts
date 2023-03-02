import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BookRoutingModule } from './book-routing.module';
import { BookLayoutComponent } from './book-layout/book-layout.component';
import { BookListComponent } from './book-list/book-list.component';
import { BookService } from './service/book.service';


@NgModule({
    declarations: [
        BookLayoutComponent,
        BookListComponent
    ],
    imports: [
        CommonModule,
        BookRoutingModule
    ],
    providers: [
        BookService
    ]
})
export class BookModule { }
