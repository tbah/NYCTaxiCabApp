using NYCTaxiCabApp.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Models
{
    public class FareSummary
    {
        public string OriginAddress { get; set; }
        public string DestinationAddress { get; set; }
        
        public DateTime RideDate { get; set; }
        public Time RideTime { get; set; }

        public decimal RideFare { get; set; }
        public decimal WeekdayPeakSursarge { get; set; }
        public decimal NightSurcharge { get; set; }
        public decimal NewYorkStateTax { get; set; }
        public decimal TotalPrice {
            get {
                    return this.RideFare + this.WeekdayPeakSursarge + this.NightSurcharge + 
                        this.NewYorkStateTax;
                }
        }

    }
}
