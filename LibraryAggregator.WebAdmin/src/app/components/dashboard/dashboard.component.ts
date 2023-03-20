import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/models/Login';
import { ApiService } from 'src/app/service/api.service';
import { AuthAdminService } from 'src/app/service/auth-admin.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public admin!: Login;
  constructor(private auth: AuthAdminService , private api: ApiService){}
  ngOnInit(){
    this.api.getAdmin(1).subscribe(res=>{
      this.admin = res;
    })
  }

  logout(){
    this.auth.singOut();
  }
   
  

}
