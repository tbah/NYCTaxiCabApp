﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Models
{
    public class Ride
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
    }
}
