import { NgModule } from '@angular/core';
import { Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { BookedComponent } from './components/menu/status booked/booked/booked.component';
import { FreeComponent } from './components/menu/status free/free/free.component';
import { AuthGuard } from './guards/auth.guard';
import { RouterModule } from "@angular/router";
import { BookingComponent } from './components/booking/booking.component';

const routes: Routes = [
  { path:'' , redirectTo:'login',pathMatch:'full'},
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent , canActivate:[AuthGuard]},
  { path: 'booked', component: BookedComponent, canActivate: [AuthGuard] },
  { path: 'free', component: FreeComponent, canActivate: [AuthGuard] },
  { path: 'booking/:id', component: BookingComponent , canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }