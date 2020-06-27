using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Repositories;
using NYCTaxiCabApp.Web.Services;
using System;

namespace NYCTaxiCabApp.Test.Services
{
    [TestClass]
    public class RideServiceTest
    {
        private Mock<IRideRepository> _mockRepository;

        [TestInitialize]
        public void InitializeTest()
        {
            _mockRepository = new Mock<IRideRepository>();
            _mockRepository.Setup(r => r.GetNYSTax())
                .Returns(1);
            _mockRepository.Setup(r => r.GetRideFare(It.IsAny<Ride>()))
                .Returns(3);
            _mockRepository.Setup(r => r.NightSurcharge(It.IsAny<Ride>()))
                .Returns(0);
            _mockRepository.Setup(r => r.WeekDayPeakSurcharge(It.IsAny<Ride>()))
                .Returns(0);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            RideService rideService = new RideService(_mockRepository.Object);
            Assert.IsNotNull(rideService);
        }
        [TestMethod]
        public void GetFareSummaryTest()
        {
            RideService rideService = new RideService(_mockRepository.Object);
            Ride ride = new Ride()
            {
                RideDate = new DateTime(2020, 6, 26),
                DistanceCoveredSlowSpeed = 1,
                RideTime = new Time()
                {
                    Hour = 12,
                    Minute = 16
                }
            };

            var result = rideService.GetFareSummary(ride);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.TotalPrice, 4);
        }
    }
}
