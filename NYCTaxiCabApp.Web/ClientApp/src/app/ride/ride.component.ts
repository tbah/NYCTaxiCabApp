import { Component, OnInit } from '@angular/core';
import {NgbDateStruct} from '@ng-bootstrap/ng-bootstrap';
import { IRide, Ride } from '../models/ride';
@Component({
  selector: 'app-ride',
  templateUrl: './ride.component.html',
  styleUrls: ['./ride.component.css']
})
export class RideComponent implements OnInit {
  model: NgbDateStruct;

  private ride: IRide = new Ride();
  constructor() { }

  ngOnInit() {
  }
  time = {hour: 13, minute: 30};
  meridian = true;

  toggleMeridian() {
      this.meridian = !this.meridian;
  }

  createRide(isValid: boolean){
    console.log(this.ride);
  }

}
