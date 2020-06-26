using NYCTaxiCabApp.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Models
{
    public class RideViewModel
    {
        public double DistanceCoveredSlowSpeed { get; set; }
        public double DistanceCoveredFasterSpeed { get; set; }
        public Time DurationWithSlowSpeed { get; set; }
        public Time DurationWithFastSpeed { get; set; }
        public Time AmountTimeWithoutMotion { get; set; }
        public Date RideDate { get; set; } 
        public Time RideTime { get; set; }
        public string OriginAddress { get; set; } 
        public string DestinationAdress { get; set; } 

        public void UpdateModel(Ride ride)
        {
            ride.DistanceCoveredSlowSpeed = this.DistanceCoveredSlowSpeed;
            ride.DistanceCoveredFasterSpeed = this.DistanceCoveredFasterSpeed;
            ride.DurationWithFastSpeed = this.DurationWithFastSpeed;
            ride.DurationWithSlowSpeed = this.DurationWithSlowSpeed;
            ride.AmountTimeWithoutMotion = this.AmountTimeWithoutMotion;
            ride.RideDate = this.RideDate.GetDate();
            ride.RideTime = this.RideTime;
            ride.OriginAddress = this.OriginAddress;
            ride.DestinationAdress = this.DestinationAdress;
        }
    }
}
