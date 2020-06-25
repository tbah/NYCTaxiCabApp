import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IRide } from '../models/ride';
import { Observable, of, from } from 'rxjs';
import { catchError} from 'rxjs/operators'

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
@Injectable({
  providedIn: 'root'
})
export class RideService {
  private baseUrl: string;
  constructor(private _httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      this.baseUrl = baseUrl;
   }

  addRide(ride: IRide):Observable<any>{
    let url: string = this.baseUrl + "api/Ride";
    console.log(this.baseUrl);
    return this._httpClient.post<IRide>(url, ride, httpOptions)
      .pipe(
        catchError(this.handleError<IRide>('addRide'))
      );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.log(operation + " failed with error message " + error.message);
      return of(error.error as T);
    }
  }
}
