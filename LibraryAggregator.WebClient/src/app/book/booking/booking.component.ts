import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { BookingApiService } from 'src/app/api-services/booking-api.service';
import { BookingDto } from 'src/app/models/Dtos/bookingDto';

@Component({
    selector: 'app-booking',
    templateUrl: './booking.component.html',
    styleUrls: ['./booking.component.css']
})

export class BookingComponent implements OnInit {

    booking: BookingDto = {}
    bookingForm!: FormGroup;

    constructor(private readonly bookingService: BookingApiService,
        private route: ActivatedRoute) {
    }

    ngOnInit(): void {
        this.bookingForm = new FormGroup({
            'name': new FormControl('', [Validators.pattern('^[A-Za-zА-Яа-яЁё]{1,20}$')]),
            'surname': new FormControl('', [Validators.pattern('^[A-Za-zА-Яа-яЁё]{1,20}$')]),
            'email': new FormControl('', [Validators.required, Validators.email]),
            'phone': new FormControl('', [Validators.required, Validators.pattern('[- +()0-9]+')]),
        })
    }

    submitBooking() {
        this.booking.name = this.bookingForm.value.name;
        this.booking.surname = this.bookingForm.value.surname;
        this.booking.email = this.bookingForm.value.email;
        this.booking.phoneNumber = this.bookingForm.value.phone;
        this.booking.bookLibraryId = this.route.snapshot.params["id"];
        this.bookingService.addBooking(this.booking).subscribe();
        console.log(this.booking)
    }
}
