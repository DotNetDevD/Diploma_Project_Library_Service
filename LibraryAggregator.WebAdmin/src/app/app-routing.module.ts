import { inject, NgModule } from '@angular/core';
import { Router, RouterModule, Routes } from '@angular/router';
import { LoginFormComponent } from 'src/modules/login/login-form/login-form.component';
import { AuthService } from 'src/modules/shared/service/auth.service';

const canLoadBookModule = () => {
    const authService = inject(AuthService);
    const router = inject(Router);

    if (authService.isAuthenticated) {
        return true;
    }

    router.navigate(['']);
    return;
}

const routes: Routes = [
    {
        path: '', component: LoginFormComponent,
    },
    {
        path: 'book',
        loadChildren: () => import('../modules/book/book.module').then(m => m.BookModule),
        canMatch: [canLoadBookModule]
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
