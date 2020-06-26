import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { RideComponent } from './ride/ride.component';
import { RoutingModule } from './routing/routing.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RideService } from './services/ride.service';
import { FareSummaryComponent } from './fare-summary/fare-summary.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    RideComponent,
    FareSummaryComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgbModule,
    FormsModule,
    RoutingModule
  ],
  providers: [RideService],
  bootstrap: [AppComponent]
})
export class AppModule { }
