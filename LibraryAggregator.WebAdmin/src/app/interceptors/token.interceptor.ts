import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';
import { AuthAdminService } from '../service/auth-admin.service';
import { NgToastComponent, NgToastService } from 'ng-angular-popup';
import { Router } from '@angular/router';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {

  constructor(private auth: AuthAdminService, private toast: NgToastService , private router: Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const token = this.auth.getToken();
    if(token){
      request = request.clone({
          setHeaders: {Authorization: `Bearer ${token}`}
        })
      
    }
    return next.handle(request).pipe(
      catchError((err:any) =>{
        if(err instanceof HttpErrorResponse){
          if(err.status === 401){
            this.toast.warning({detail:"Warning",summary:"Token is expired, Login again"});
            this.router.navigate(['login'])
          }
        }
        return throwError(()=> new Error("Some other error occurred"))
      })
    );
  }
}
