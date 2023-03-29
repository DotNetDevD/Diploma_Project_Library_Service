import { Injectable } from '@angular/core';
import { CanActivate, Router} from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { AuthAdminService } from '../service/auth-admin.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private auth: AuthAdminService , private router:Router , private toast: NgToastService){

  }
  canActivate(): boolean{
    if(this.auth.isLoggedIn()){
      return true;
    }
    this.toast.error({detail:"ERROR",summary:"Not logged User"})
    this.router.navigate(['login'])
    return false;
  }
  
}
