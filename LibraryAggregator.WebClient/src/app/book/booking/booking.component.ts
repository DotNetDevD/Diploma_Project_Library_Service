import { Component } from '@angular/core';
import { ClientDto } from 'src/app/models/Dtos/clientDto';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent {
  client?: ClientDto;
}
