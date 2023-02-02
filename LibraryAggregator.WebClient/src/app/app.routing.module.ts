import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { BookShowComponent } from "./book/book-show/book-show.component";
import { LibraryCardComponent } from "./library/library-card/library-card.component";
import { LibraryComponent } from "./library/library.component";
import { MainContentComponent } from "./main-content/main-content.component";
import { PageNotFoundComponent } from "./page-not-found/page-not-found.component";
import { TestComponent } from "./test/test.component";

const appRoutes: Routes = [
    { path: 'book/book-show', component: BookShowComponent },
    { path: 'library/test', component: TestComponent },
    { path: 'index', component: MainContentComponent },
    { path: 'test', component: TestComponent },
    { path: 'library', component: LibraryComponent },
    { path: 'library/library-card', component: LibraryCardComponent },
    { path: '', redirectTo: '/index', pathMatch: 'full' },
    { path: '**', component: PageNotFoundComponent }
    
];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes)],
    exports: [RouterModule]
})

export class AppRoutingModule {

}