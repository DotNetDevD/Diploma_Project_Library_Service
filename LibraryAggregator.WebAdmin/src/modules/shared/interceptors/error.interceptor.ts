import { Injectable } from '@angular/core';
import {
    HttpRequest,
    HttpHandler,
    HttpEvent,
    HttpInterceptor,
    HttpErrorResponse
} from '@angular/common/http';
import { catchError, Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

    constructor(private readonly router: Router) { }

    intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
        return next.handle(request)
            .pipe(catchError((e, cauthg) => {
                if (e instanceof HttpErrorResponse) {
                    this.handleHttpErrorResponse(e);
                }

                throw new Error(e.message);
            }));
    }
    
    private handleHttpErrorResponse(e: HttpErrorResponse) {
        switch (e.status) {
            case 401:
                alert('user dosn\'t authorized');
                this.router.navigate(['']);
                break;
        
            default:
                break;
        }
    }
}
