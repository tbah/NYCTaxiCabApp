using NYCTaxiCabApp.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Utilities
{
    public class RideManager
    {
        public decimal calculateRideFare(Ride ride)
        {
            decimal totalPrice = RateConstant.BASE_RATE + RateConstant.ADDITIONAL_UNIT * Units(ride) +
                    WeekDayPeakSurcharge(ride) + NightSurcharge(ride) + RateConstant.NYS_TAX;
           
            return totalPrice;
        }

        private int Units(Ride ride)
        {
            int nUnits = 0;

            nUnits = (int)(ride.DistanceCoveredSlowSpeed * RateConstant.UNITS_PERMILE);

            int durationFastMins = ride.DurationWithFastSpeed == null ? 0 : ride.DurationWithFastSpeed.getInMinutes();
            int durationWithoutMotionMins = ride.AmountTimeWithoutMotion == null ? 0 : ride.AmountTimeWithoutMotion.getInMinutes();

            nUnits += durationFastMins + durationWithoutMotionMins;


            return nUnits;
        }

        private decimal WeekDayPeakSurcharge(Ride ride)
        {
            if (ride.RideDate.DayOfWeek > DayOfWeek.Sunday && ride.RideDate.DayOfWeek < DayOfWeek.Saturday)
                if (ride.RideTime.Hour >= RateConstant.WEEKDAY_PEAK_START && ride.RideTime.Hour < RateConstant.WEEKDAY_PEAK_END)
                    return RateConstant.WEEKDAY_PEAK_SURCHARGE;
            return 0;
        }

        private decimal NightSurcharge(Ride ride)
        {
            if (ride.RideTime.Hour >= RateConstant.NIGHT_SURCHARGE_START && ride.RideTime.Hour < RateConstant.NIGHT_SURCHARGE_END)
                return RateConstant.NIGHT_SURGCHARGE;
            return 0;
        }
    }
}
