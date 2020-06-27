using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Entities
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public int getInMinutes()
        {
            return this.Hour * 60 + this.Minute;
        }
    }
}
