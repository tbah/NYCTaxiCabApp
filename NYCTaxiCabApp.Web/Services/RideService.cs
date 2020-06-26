using NYCTaxiCabApp.Web.Entities;
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
        public decimal Calculate(Ride ride)
        {
           return _rideManager.calculateRideFare(ride);
        }   
    }
}
