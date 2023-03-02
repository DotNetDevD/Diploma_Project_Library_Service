import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookLayoutComponent } from './book-layout/book-layout.component';
import { BookListComponent } from './book-list/book-list.component';

const routes: Routes = [
  {
    path: '', component: BookLayoutComponent,
    children: [
      {
        path: '', component: BookListComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BookRoutingModule { }
