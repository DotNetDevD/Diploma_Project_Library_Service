import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';

@Injectable({
    providedIn: 'root'
})
export class RequestBuilderService {

    // private defaltHeaders: HttpHeaders = 
    // [
    //   { }
    // ]
    private endpointUrl = ''
    constructor(private readonly httpClient: HttpClient) { }

    setEndpoint(endpoint: string): RequestBuilderService {
        this.endpointUrl = `${environment.apiUrl}/${endpoint}`;

        return this;
    }

    post<T>(data: any): Observable<T> {
        return this.httpClient.post<T>(this.endpointUrl, data);
    }

    get<T>(params?: { [param: string]: string | number | boolean }): Observable<T> {
        return this.httpClient.get<T>(this.endpointUrl, params);
    }
}
