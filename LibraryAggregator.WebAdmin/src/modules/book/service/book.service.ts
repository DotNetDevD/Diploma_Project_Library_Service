import { Injectable } from '@angular/core';
import { RequestBuilderService } from 'src/modules/shared/service/request-builder.service';

@Injectable({
    providedIn: 'root'
})
export class BookService {

    constructor(private readonly rb: RequestBuilderService) { }

    getBook() {
        return this.rb.setEndpoint('book')
            .get();
    }
}
