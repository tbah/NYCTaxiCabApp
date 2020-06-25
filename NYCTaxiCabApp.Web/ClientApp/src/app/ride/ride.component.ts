import { Component, OnInit } from '@angular/core';
import {NgbDateStruct} from '@ng-bootstrap/ng-bootstrap';
import { IRide, Ride } from '../models/ride';
import { RideService } from '../services/ride.service';
@Component({
  selector: 'app-ride',
  templateUrl: './ride.component.html',
  styleUrls: ['./ride.component.css']
})
export class RideComponent implements OnInit {
  model: NgbDateStruct;

  private ride: IRide = new Ride();

  private modelState = [];
  
  constructor(private _rideService: RideService) { }

  ngOnInit() {
    console.log(this.ride);
  }
  time = {hour: 13, minute: 30};
  meridian = true;

  toggleMeridian() {
      this.meridian = !this.meridian;
  }

  createRide(isValid: boolean): void{
    this.modelState = [];    
    if(!isValid){
      this.validateInputs();
    }else{
      this._rideService.addRide(this.ride).subscribe( results => {
        console.log(results)
      })
    }
   
  }

  validateInputs(): void{    
      if(this.ride.rideTime == undefined || this.ride.rideTime == null){
        this.modelState.push("Ride Time is required");
      }
      console.log(this.ride.isInValid())
      if(this.ride.isInValid()){
        this.modelState.push("At least one of the following: Distance Under 6 MPH, Distance Above 6 MPH, Duration without Motion, must have value ")
      }
  }

}
