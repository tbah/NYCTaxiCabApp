using Microsoft.VisualStudio.TestTools.UnitTesting;
using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Repositories;
using NYCTaxiCabApp.Web.Utilities;
using System;

namespace NYCTaxiCabApp.Test.Repositories
{
    [TestClass]
    public class RideRepositoryTest
    {
        [TestMethod]
        public void GetNYSTaxTest()
        {
            RideRepository repo = new RideRepository();

            var res = repo.GetNYSTax();

            Assert.AreEqual(RateConstant.NYS_TAX, res);
        }

        [TestMethod]
        public void GetRideFareTest()
        {
            RideRepository repo = new RideRepository();

            Time rideTime = new Time()
            {
                Hour = 10,
                Minute = 16
            };
            Ride ride = new Ride()
            {
                RideDate = DateTime.Now,
                DistanceCoveredSlowSpeed = 1,
                RideTime = rideTime
            };
            var res = repo.GetRideFare(ride);
            Assert.AreEqual(RateConstant.BASE_RATE + 
                RateConstant.ADDITIONAL_UNIT * RateConstant.UNITS_PERMILE, res);
        }

        [TestMethod]
        public void WeekDayPeakSurchargeTest()
        {
            RideRepository repo = new RideRepository();

            Time rideTime = new Time()
            {
                Hour = 17,
                Minute = 16
            }; // 17 = 5pm
            Ride ride1 = new Ride()
            {
                RideDate = new DateTime(2020, 6, 26),
                DistanceCoveredSlowSpeed = 1,
                RideTime = rideTime
            };

            Ride ride2 = new Ride()
            {
                RideDate = new DateTime(2020, 6, 27),
                DistanceCoveredSlowSpeed = 1,
                RideTime = rideTime
            };
            var res1 = repo.WeekDayPeakSurcharge(ride1);
            var res2 = repo.WeekDayPeakSurcharge(ride2);
            Assert.AreEqual(RateConstant.WEEKDAY_PEAK_SURCHARGE, res1);
            Assert.AreEqual(0, res2);
        }

        [TestMethod]
        public void NightSurchargeTest()
        {
            RideRepository repo = new RideRepository();

            Time rideTime = new Time()
            {
                Hour = 17,
                Minute = 16
            }; // 17 = 5pm
            Ride ride1 = new Ride()
            {
                RideDate = new DateTime(2020, 6, 26),
                DistanceCoveredSlowSpeed = 1,
                RideTime = rideTime
            };

            Ride ride2 = new Ride()
            {
                RideDate = new DateTime(2020, 6, 26),
                DistanceCoveredSlowSpeed = 1,
                RideTime = new Time()
                {
                    Hour = 1,
                    Minute = 16
                }
            }; // Ride2 at 1am 
            var res1 = repo.NightSurcharge(ride1);
            var res2 = repo.NightSurcharge(ride2);
            Assert.AreEqual(0, res1);
            Assert.AreEqual(RateConstant.NIGHT_SURGCHARGE, res2);
        }


    }
}
