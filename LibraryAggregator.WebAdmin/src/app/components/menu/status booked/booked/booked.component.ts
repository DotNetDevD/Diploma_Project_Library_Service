import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Booking } from 'src/app/models/Booking';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-booked',
  templateUrl: './booked.component.html',
  styleUrls: ['./booked.component.css']
})
export class BookedComponent implements OnInit{
onDelete() {
  this.api.deleteRecord(19).subscribe();
  this.router.navigate(['free']);
}
  public BooksBooking:Booking[] =[];
  constructor(private api: ApiService, private route: ActivatedRoute,private router: Router){}
  ngOnInit(): void {
    this.api.getBookingBooks().subscribe({
      next: (res) => {
        this.BooksBooking = res
    }
  });
   
}
}
