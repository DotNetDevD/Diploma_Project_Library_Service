import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { BookedComponent } from './components/menu/status booked/booked/booked.component';
import { FreeComponent } from './components/menu/status free/free/free.component';
import { GivenToTheClientComponent } from './components/menu/status given to the client/given-to-the-client/given-to-the-client.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  { path:'' , redirectTo:'login',pathMatch:'full'},
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent , canActivate:[AuthGuard]},
  { path: 'booked', component:BookedComponent},
  { path: 'free' , component:FreeComponent},
  { path: 'given-to-the-client' , component:GivenToTheClientComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }