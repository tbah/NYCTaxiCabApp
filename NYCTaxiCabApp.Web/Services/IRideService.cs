using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYCTaxiCabApp.Web.Services
{
    public interface IRideService
    {
       FareSummary GetFareSummary(Ride ride);

    }
}
