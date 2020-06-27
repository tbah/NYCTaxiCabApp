using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Models;
using NYCTaxiCabApp.Web.Repositories;
using NYCTaxiCabApp.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Services
{
    public class RideService: IRideService
    {
        IRideRepository _rideRepository;

        public RideService(IRideRepository rideRepository) 
        {
            _rideRepository = rideRepository;
        }
        public FareSummary GetFareSummary(Ride ride)
        {
            FareSummary fareSummary = new FareSummary();
            fareSummary.DestinationAddress = ride.DestinationAdress;
            fareSummary.OriginAddress = ride.OriginAddress;
            fareSummary.RideDate = ride.RideDate;
            fareSummary.RideTime = ride.RideTime;
            fareSummary.RideFare = _rideRepository.GetRideFare(ride);
            fareSummary.WeekdayPeakSursarge = _rideRepository.WeekDayPeakSurcharge(ride);
            fareSummary.NightSurcharge = _rideRepository.NightSurcharge(ride);
            fareSummary.NewYorkStateTax = _rideRepository.GetNYSTax();
            
           return fareSummary;
        }   
    }
}
