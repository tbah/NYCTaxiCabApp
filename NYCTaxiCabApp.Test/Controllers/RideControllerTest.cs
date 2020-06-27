using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NYCTaxiCabApp.Web.Controllers;
using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Models;
using NYCTaxiCabApp.Web.Services;

namespace NYCTaxiCabApp.Test.Controllers
{
    [TestClass]
    public class RideControllerTest
    {
        private Mock<IRideService> _mockRideService;
        [TestInitialize]
        public void InitializeTest()
        {
            _mockRideService = new Mock<IRideService>();

            _mockRideService.Setup(service => service.GetFareSummary(It.IsAny<Ride>()))
                .Returns(
                    new FareSummary()
                    {
                        NewYorkStateTax = 1,
                        RideFare = 4
                    }

                );
        }

        [TestMethod]
        public void ConstructorTest()
        {
            RideController rideController = new RideController(_mockRideService.Object);
            Assert.IsNotNull(rideController);
        }

        [TestMethod]
        public void PostTest()
        {
            RideController rideController = new RideController(_mockRideService.Object);
            RideViewModel rideViewModel = new RideViewModel();
            var result = rideController.Post(rideViewModel);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.TotalPrice, 5);
        }
    }
}
