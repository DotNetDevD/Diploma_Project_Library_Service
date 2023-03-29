import { Component, OnInit } from '@angular/core';
import { Booking } from 'src/app/models/Booking';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-booked',
  templateUrl: './booked.component.html',
  styleUrls: ['./booked.component.css']
})
export class BookedComponent implements OnInit{
  public BooksBooking:Booking[] =[];
  constructor(private api : ApiService){}
  ngOnInit(): void {
    this.api.getBookingBooks().subscribe({
      next: (res) => {
        this.BooksBooking = res
    }
  });
}
}
