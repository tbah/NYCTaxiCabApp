import { Time } from '../models/time';

export interface IRide{
    distanceCoveredSlowSpeed: number;
    distanceCoveredFasterSpeed: number;
    durationWithSlowSpeed: Time;
    durationWithFastSpeed: Time; 
    amountTimeWithoutMotion: Time;
    rideDate: Date; 
    rideTime: Time; 
    originAddress: string; 
    destinationAdress: string; 
    isInValid(): boolean;
} 

export class Ride implements IRide{
    distanceCoveredSlowSpeed: number;
    distanceCoveredFasterSpeed: number;
    durationWithSlowSpeed: Time;
    durationWithFastSpeed: Time;
    amountTimeWithoutMotion: Time;
    rideDate: Date;
    rideTime: any;
    originAddress: string;
    destinationAdress: string;

    public isInValid(): boolean{
        let distSlow = this.distanceCoveredSlowSpeed || 0;
        let distFast = this.distanceCoveredFasterSpeed || 0;
        return (distSlow + distFast + this.getMinutes(this.amountTimeWithoutMotion)) <= 0 ;
    }

    private getMinutes(time: Time): number{
        if(time == undefined || time == null)
            return 0;
        return time.hour * 60 + time.minute;
    }

}
