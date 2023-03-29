import { Component, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from 'src/app/service/api.service'
import { BookingDto } from 'src/app/models/BookingDto';

@Component({
    selector: 'app-booking',
    templateUrl: './booking.component.html',
    styleUrls: ['./booking.component.css']
})

export class BookingComponent implements OnInit {

    @Output() booking: BookingDto = {}
    bookingForm!: FormGroup;
    isFormSent = false;

    constructor(private readonly bookingService: ApiService,
        private route: ActivatedRoute,
        private router: Router) { }


    ngOnInit(): void {
        this.bookingForm = new FormGroup({
            'name': new FormControl('', [Validators.pattern('^[A-Za-zА-Яа-яЁё]{1,20}$')]),
            'surname': new FormControl('', [Validators.pattern('^[A-Za-zА-Яа-яЁё]{1,20}$')]),
            'email': new FormControl('', [Validators.required, Validators.email]),
            'phone': new FormControl('', [Validators.required, Validators.pattern('[- +()0-9]+')]),
        })
    }

    submitBooking() {
        this.isFormSent = true;
        this.booking.name = this.bookingForm.value.name;
        this.booking.surname = this.bookingForm.value.surname;
        this.booking.email = this.bookingForm.value.email;
        this.booking.phoneNumber = this.bookingForm.value.phone;
        this.booking.bookLibraryId = this.route.snapshot.params["id"];
        this.bookingService.addBooking(this.booking).subscribe();
        this.router.navigate(['free'])
    }
}
