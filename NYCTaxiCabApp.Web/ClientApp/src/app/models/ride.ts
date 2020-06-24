import { Time } from "@angular/common";

export interface IRide{
    distanceCoveredSlowSpeed: number; //c
    distanceCoveredFasterSpeed: number; //c
    durationWithSlowSpeed: Time; //c
    durationWithFastSpeed: Time; //c
    amountTimeWithoutMotion: Time;
    rideDate: Date; //c
    rideTime: Time; //c
    originAddress: string; //c
    destinationAdress: string; //c
} 

export class Ride implements IRide{
    distanceCoveredSlowSpeed: number;
    distanceCoveredFasterSpeed: number;
    durationWithSlowSpeed: Time;
    durationWithFastSpeed: Time;
    amountTimeWithoutMotion: Time;
    rideDate: Date;
    rideTime: Time;
    originAddress: string;
    destinationAdress: string;

}