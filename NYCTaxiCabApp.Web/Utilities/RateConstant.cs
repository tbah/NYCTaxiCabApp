using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Utilities
{
    public class RateConstant
    {
        public readonly static decimal BASE_RATE = 3.0M;
        public readonly static decimal ADDITIONAL_UNIT = 0.35M;
        public readonly static decimal WEEKDAY_PEAK_SURCHARGE = 1.0M;
        public readonly static decimal NIGHT_SURGCHARGE = 0.5M;
        public readonly static decimal NYS_TAX = 0.5M;

        public readonly static int UNITS_PERMILE = 5;

        public readonly static int WEEKDAY_PEAK_START = 16; // 4pm
        public readonly static int WEEKDAY_PEAK_END = 20; // 8pm

        public readonly static int NIGHT_SURCHARGE_START = 20;
        public readonly static int NIGHT_SURCHARGE_END = 6;

    }
}
