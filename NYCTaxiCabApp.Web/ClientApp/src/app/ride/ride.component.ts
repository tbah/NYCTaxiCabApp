import { Component, OnInit } from '@angular/core';
import {NgbDateStruct} from '@ng-bootstrap/ng-bootstrap';
import { IRide, Ride } from '../models/ride';
import { RideService } from '../services/ride.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-ride',
  templateUrl: './ride.component.html',
  styleUrls: ['./ride.component.css']
})
export class RideComponent implements OnInit {
  model: NgbDateStruct;

  private ride: IRide = new Ride();

  private modelState = [];
  
  constructor(private _rideService: RideService, private router: Router) { }

  ngOnInit() {
    
  }
  time = {hour: 13, minute: 30};
  meridian = true;

  toggleMeridian() {
      this.meridian = !this.meridian;
  }

  createRide(isValid: boolean): void{
    this.modelState = [];   

    if(this.validateInputs(isValid)){
      this._rideService.addRide(this.ride).subscribe( results => {
        this._rideService.fareSummary = results;
        console.log(results);
        this.router.navigate(['/fareSummary']);
      });

      console.log(this.ride);
    }
   
  }

  validateInputs(isValid: boolean): boolean{  
      let valid = true;  
      if(this.ride.rideTime == undefined || this.ride.rideTime == null){
        this.modelState.push("Ride Time is required");
        valid = false;
      }      
      if(this.ride.isInValid()){
        this.modelState.push("At least one of the following: Distance Under 6 MPH, Duration Above 6 MPH, Duration without Motion, must have value ")
        valid = false;
      }
      if(!isValid) valid = false;
      return valid;
  }
}
