import { Component, OnInit } from '@angular/core';
import { IFareSummary } from '../models/fare-summary';
import { RideService } from '../services/ride.service';
import { Router } from '@angular/router';
import { Time } from '../models/time';

@Component({
  selector: 'app-fare-summary',
  templateUrl: './fare-summary.component.html',
  styleUrls: ['./fare-summary.component.css']
})
export class FareSummaryComponent implements OnInit {

  private fareSummary: IFareSummary;
  constructor(private _rideService: RideService, private router: Router) { }

  private time: string;
  ngOnInit() {
    this.fareSummary = this._rideService.fareSummary;
    if(this.fareSummary == undefined || this.fareSummary == null){
      this.router.navigate(['/']);
    }
    this.time = this.formatTime(this.fareSummary.rideTime);
  }

  private formatTime(time: Time): string{ 
        let m : string = "AM";
        let h: number = time.hour;
        if(time.hour >= 12){
            m = "PM";
            h = h % 12;
        }
        if(h == 0)   h = 12;
        
        return ("00" + h).slice(-2) +':'+ ("00" + time.minute).slice(-2)+' '+m;
      
    }

}
