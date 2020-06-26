using NYCTaxiCabApp.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Repositories
{
    public interface IRideRepository
    {
        decimal GetNYSTax();

        decimal GetRideFare(Ride ride);

        decimal WeekDayPeakSurcharge(Ride ride);

        decimal NightSurcharge(Ride ride);
    }
}
