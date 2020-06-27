import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { RideComponent } from './ride.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { RideService } from '../services/ride.service';
import { IRide, Ride } from '../models/ride';
import { FareSummary } from '../models/fare-summary';
import { of } from 'rxjs';
import { By } from '@angular/platform-browser';
import { Button } from 'protractor';

describe('RideComponent', () => {
  let component: RideComponent;
  let fixture: ComponentFixture<RideComponent>;
  let mockRideService: any;
  beforeEach(async(() => {
    mockRideService = jasmine.createSpyObj('RideService', ['addRide']);
    mockRideService.addRide.and.returnValue(of( new FareSummary()));

    TestBed.configureTestingModule({
      declarations: [ RideComponent ],
      imports: [
        FormsModule, 
        NgbModule, 
        RouterTestingModule,
        HttpClientTestingModule],
      providers: [{provide: RideService, useValue: mockRideService}]
      
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('should have createRide', () =>{
    expect(component.createRide).toBeTruthy();
  });

  it('should have only one ul', ()=>{
    const unorderedList = fixture.debugElement.queryAll(By.css('ul'));
    expect(unorderedList.length).toBe(1);
  });

  it('should have no one li when modelSate is empty', ()=>{
    const listItems = fixture.debugElement.queryAll(By.css('li'));
    expect(listItems.length).toBe(0);
  });

  it('should have at least one li when modelSate has one item', ()=>{
    component.validateInputs(false);
    fixture.detectChanges()
    const listItems = fixture.debugElement.queryAll(By.css('li'));
    expect(listItems.length > 0).toBeTruthy
  });

  it('should be called when submit button is clicked', ()=>{
    const list = fixture.debugElement.queryAll(By.css('button'));
    spyOn(component, 'createRide');
    list.forEach(button => {
      const buttonElement: HTMLButtonElement = button.nativeElement;
        if(buttonElement.textContent == "Submit")
            buttonElement.click();
    });
    expect(component.createRide).toHaveBeenCalledWith(true);

  });

  // it('createRide should be able to create a ride and get result back', ()=>{
  //   let ride: IRide = new Ride();
  //   expect(component.createRide(false)).toBeTruthy();
  // });
  
});




