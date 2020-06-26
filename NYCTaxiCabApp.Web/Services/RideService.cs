using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Models;
using NYCTaxiCabApp.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Services
{
    public class RideService: IRideService
    {
        RideManager _rideManager;

        public RideService()
        {
            _rideManager = new RideManager();
        }
        public FareSummary GetFareSummary(Ride ride)
        {
            FareSummary fareSummary = new FareSummary();
            fareSummary.DestinationAddress = ride.DestinationAdress;
            fareSummary.OriginAddress = ride.OriginAddress;
            fareSummary.RideDate = ride.RideDate;
            fareSummary.RideTime = ride.RideTime;
            fareSummary.RideFare = _rideManager.GetRideFare(ride);
            fareSummary.WeekdayPeakSursarge = _rideManager.WeekDayPeakSurcharge(ride);
            fareSummary.NightSurcharge = _rideManager.NightSurcharge(ride);
            fareSummary.NewYorkStateTax = _rideManager.GetNYSTax();
            
           return fareSummary;
        }   
    }
}
