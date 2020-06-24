import { Time } from "@angular/common";

export interface IRide{
    distanceCoveredSlowSpeed: number; //c
    distanceCoveredFasterSpeed: number; //c
    durationWithSlowSpeed: Time; //c
    durationWithFastSpeed: Time; //c
    amountTimeWithoutMotion: Time;
    RideDate: Date; //c
    RideTime: Time; //c
    originAddress: string; //c
    destinationAdrees: string; //c
} 