import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from 'src/app/models/Login';
import { AdminJwtService } from 'src/app/service/admin-jwt.service';
import { ApiService } from 'src/app/service/api.service';
import { AuthAdminService } from 'src/app/service/auth-admin.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public admin :Login  = {
    token: '' 
  };
  public Name : string ="";
  constructor(private auth: AuthAdminService ,
               private api: ApiService ,
               private adminJwt: AdminJwtService,
               private router: Router){}
  ngOnInit(){
    this.api.getAdmin(1)
    .subscribe({
      next: (res) => {
      this.admin = res
      console.log(this.admin.message)
      }
      }
    )

    this.adminJwt.getName()
    .subscribe(res =>{
      let admName = this.auth.getAdminNameFromToken();
      this.Name = res || admName;
    });
  }

  logout(){
    this.auth.singOut();
  }
   
  onBooked(){
    this.router.navigate(['booked'])
  }
  

}
