import { Injectable } from '@angular/core';
import { tap } from 'rxjs';
import { RequestBuilderService } from './request-builder.service';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private _isUserAuthenticated = false;
    private _token = '';

    constructor(private readonly rb: RequestBuilderService) { }

    get isAuthenticated() {
        return this._isUserAuthenticated;
    }


    login(loginForm: any) {
        return this.rb.setEndpoint('user/login')
            .post(loginForm)
            .pipe(
                tap((r: any) => {
                    this._isUserAuthenticated = r.isSuccess;
                    if (r.isSuccess) {
                        this._token = r.token;
                    }
                })
            );
    }

    get token() {
        return this._token;
    }
}
