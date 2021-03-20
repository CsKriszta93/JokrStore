import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { HttpClient, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing/app-routing.module';
import { PaginationModule } from 'ngx-bootstrap/pagination';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { GameListComponent } from './gameList/gameList.component';
import { GameComponent } from './game/game.component';
import { SysReqComponent } from './sysReq/sysReq.component';
import { ToastrModule } from 'ngx-toastr';
import { RegisterComponent } from './register/register.component';
import { CartComponent } from './cart/cart.component';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { TabsModule } from 'ngx-bootstrap/tabs';
import { UserDetailsComponent } from './userDetails/userDetails.component';

@NgModule({
   declarations: [				
      AppComponent,
      NavComponent,
      HomeComponent,
      GameListComponent,
      GameComponent,
      SysReqComponent,
      RegisterComponent,
      CartComponent,
      UserDetailsComponent
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      FormsModule,
      HttpClientModule,
      BsDropdownModule.forRoot(),
      NgbModule,
      AppRoutingModule,
      PaginationModule.forRoot(),
      ToastrModule.forRoot({
         positionClass: 'toast-bottom-right'
      }),
      TabsModule.forRoot()
   ],
   providers: [
      {provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
