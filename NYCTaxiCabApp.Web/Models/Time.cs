using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Models
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public int getInMinutes()
        {
            return this.Hours * 60 + this.Minutes;
        }
    }
}
