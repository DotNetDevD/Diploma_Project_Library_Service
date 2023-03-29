import { Component, OnInit } from '@angular/core';
import { BookLibrary } from 'src/app/models/BookLibrary';
import { LibraryDto } from 'src/app/models/LibraryDto';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-free',
  templateUrl: './free.component.html',
  styleUrls: ['./free.component.css']
})

export class FreeComponent implements OnInit{
  public library: LibraryDto[] =[];
  constructor(private api:ApiService){}
  ngOnInit(): void {
    this.api.getLibrary(1).subscribe({
      next: (res) => {
        this.library = res
        console.log(this.library);
        
      }
    }
    )
  }

}
