import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { BookingDto } from 'src/app/models/Dtos/bookingDto';

@Component({
    selector: 'app-success-booking',
    templateUrl: './success-booking.component.html',
    styleUrls: ['./success-booking.component.css']
})
export class SuccessBookingComponent implements OnInit {

    @Input() booking: BookingDto = {}

    ngOnInit(): void {
    }
}
