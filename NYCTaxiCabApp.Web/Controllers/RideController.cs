using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NYCTaxiCabApp.Web.Entities;
using NYCTaxiCabApp.Web.Models;
using NYCTaxiCabApp.Web.Services;

namespace NYCTaxiCabApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private IRideService _rideService;
        public RideController(IRideService rideService)
        {
            _rideService = rideService;
        }
        // GET: api/Ride
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ride/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ride
        [HttpPost]
        public decimal Post(RideViewModel rideViewModel)
        {
            Ride ride = new Ride();
            rideViewModel.UpdateModel(ride);
            decimal dec = _rideService.Calculate(ride);
            return dec;
        }

        // PUT: api/Ride/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string ride)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
