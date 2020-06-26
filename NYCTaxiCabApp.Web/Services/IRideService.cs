using NYCTaxiCabApp.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Services
{
    public interface IRideService
    {
       decimal Calculate(Ride ride);

    }
}
