import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { FareSummaryComponent } from './fare-summary.component';
import { RideService } from '../services/ride.service';
import { IFareSummary } from '../models/fare-summary';
import { By } from '@angular/platform-browser';

describe('FareSummaryComponent', () => {
  let component: FareSummaryComponent;
  let fixture: ComponentFixture<FareSummaryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FareSummaryComponent ],
      imports: [ HttpClientTestingModule, RouterTestingModule],
      providers: [{provide: RideService, useClass: MockRideService}]
      
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FareSummaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have only one ul', ()=>{
    const unorderedList = fixture.debugElement.queryAll(By.css('ul'));
    expect(unorderedList.length).toBe(1);
  });
});

class MockRideService{
  fareSummary: IFareSummary = {originAddress:"", destinationAddress:"",
  rideDate: new Date(), rideTime: {hour:12, minute:20}, rideFare:1, 
  weekdayPeakSursarge:12, newYorkStateTax: 1, totalPrice:12, nightSurcharge:1};
}