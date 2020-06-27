 import { TestBed, inject, getTestBed } from '@angular/core/testing';
 import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

import { RideService } from './ride.service';
import { IRide, Ride } from '../models/ride';


describe('RideService', () => {
  
  let httpMock: HttpTestingController;
  let rideService: RideService;
  let ride: IRide = new Ride(); 
    ride.originAddress = "Test"; 
    ride.rideDate = new Date(), 
    ride.rideTime = {hour:12, minute:20}, 
    ride.distanceCoveredSlowSpeed = 2;
  
  
  beforeEach(() => {    
    TestBed.configureTestingModule({
      imports: [
        HttpClientTestingModule,
      ],
      providers: [RideService]
    });
    rideService = TestBed.get(RideService);
    httpMock = getTestBed().get(HttpClientTestingModule);
  });
  
  it('should be created', inject([RideService], (service: RideService) => {
    expect(service).toBeTruthy();
  }));

  it('should have addRide function', inject([RideService], (service: RideService) => {
      expect(service.addRide).toBeTruthy();
  }));

  it('should add ride', (done) =>{
    rideService.addRide(ride).subscribe(result => {
      expect(result.destinationAddress).toBe('test');
    });
    done();
  });
});
