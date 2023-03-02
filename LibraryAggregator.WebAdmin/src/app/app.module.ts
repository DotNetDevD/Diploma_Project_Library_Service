import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { LoginModule } from 'src/modules/login/login.module';
import { interceptorsRegisrations } from 'src/modules/shared/interceptors';
import { AuthInterceptor } from 'src/modules/shared/interceptors/auth.interceptor';
import { ErrorInterceptor } from 'src/modules/shared/interceptors/error.interceptor';
import { AuthService } from 'src/modules/shared/service/auth.service';
import { RequestBuilderService } from 'src/modules/shared/service/request-builder.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    LoginModule,
  ],
  providers: [
    AuthService,
    RequestBuilderService,
    ...interceptorsRegisrations
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
