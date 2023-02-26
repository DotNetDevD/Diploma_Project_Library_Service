import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BookApiService } from 'src/app/api-services/book-api.service';
import { BookingApiService } from 'src/app/api-services/booking-api.service';
import { Book } from 'src/app/models/book';
import { BookLibrary } from 'src/app/models/bookLibrary';

@Component({
    selector: 'app-book-available-for-booking',
    templateUrl: './book-available-for-booking.component.html',
    styleUrls: ['./book-available-for-booking.component.css']
})
export class BookAvailableForBookingComponent {

    bookLibraries?: BookLibrary[] = [{
        booking: []
    }];
    book?: Book = {
        authorsBooks: [],
        booksGenres: [],
        booksLibraries: []
    };

    constructor(private readonly bookingService: BookingApiService,
        private readonly bookService: BookApiService,
        private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.getBookInLibraryByBookId(this.route.snapshot.params["id"]);
        console.log(this.route.snapshot)
        this.getBookById(this.route.snapshot.params["id"]);
        console.log(this.route.snapshot)
    }

    getBookInLibraryByBookId(id: number): void {
        this.bookingService.GetAvailableBookingByBookId(id)
            .subscribe({
                next: (data) => {
                    this.bookLibraries = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }

    getBookById(id: number): void {
        this.bookService.getBookById(id)
            .subscribe({
                next: (data) => {
                    this.book = data;
                    console.log(data);
                },
                error: (e) => console.error(e)
            });
    }
}
