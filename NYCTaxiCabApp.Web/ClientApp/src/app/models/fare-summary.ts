import { Time } from '../models/time';
export interface IFareSummary{
    originAddress : string;
    destinationAddress: string        
    rideDate: Date;
    rideTime: Time;
    rideFare : number ;
    weekdayPeakSursarge : number ;
    nightSurcharge : number ;
    newYorkStateTax : number ;
    totalPrice: number ;
}