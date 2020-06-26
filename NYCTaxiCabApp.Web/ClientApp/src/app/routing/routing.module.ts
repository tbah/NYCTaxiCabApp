import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { RideComponent } from '../ride/ride.component';
import { FareSummaryComponent } from '../fare-summary/fare-summary.component';

const routes: Routes = [
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'ride', component: RideComponent},
      {path: 'fareSummary', component: FareSummaryComponent}

    ];

@NgModule({
  exports: [RouterModule],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  declarations: []
})
export class RoutingModule { }
