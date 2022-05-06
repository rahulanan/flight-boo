using Backend.DTOs;
using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCORSPolicy")]
    public class FlightController : ControllerBase
    {
        FlightDbContext ctx = new FlightDbContext();
        // GET: api/<FlightController>
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return ctx.Flights.ToList();
        }

        // GET api/<FlightController>/5
        [HttpGet]
        [Route("SearchFlights")]
        public IActionResult SearchFlights([FromBody] FlightSearchDetails flightsToBeSearched)
        {
            IEnumerable<Flight> AvailableFlights = ctx.Flights.Where(flight =>
            flight.Source.Equals(flightsToBeSearched.Source) &&
            flight.Destination.Equals(flightsToBeSearched.Destination) &&
            flight.TravelDate.Date == flightsToBeSearched.DateOfTravel.Date);

            if (AvailableFlights.Any())
            {
                return Ok(AvailableFlights);
            }
            else
            {
                return BadRequest("No Flights Available!");
            }
        }


        // POST api/<FlightController>
        [HttpPost]
        public string Post([FromBody] Flight NewFlight)
        {
            ctx.Flights.Add(NewFlight);

            ctx.SaveChanges();

            return "Flight added successfully!";
        }

        // PUT api/<FlightController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Flight updatedDetails)
        {
            var flightToBeUpdated = ctx.Flights.Find(id);

            if (flightToBeUpdated != null)
            {
    
                flightToBeUpdated.Source = updatedDetails.Source;
                flightToBeUpdated.Destination = updatedDetails.Destination;
                flightToBeUpdated.TravelDate = updatedDetails.TravelDate;
                flightToBeUpdated.ArrivalTime = updatedDetails.ArrivalTime;
                flightToBeUpdated.Departure = updatedDetails.Departure;
                flightToBeUpdated.Price = updatedDetails.Price;
                flightToBeUpdated.AvailableSeats = updatedDetails.AvailableSeats;
                flightToBeUpdated.TotalSeats = updatedDetails.TotalSeats;
               
                ctx.SaveChanges();

                return Ok("Flights updated successfully!");
            }
            else
            {
                return BadRequest("Flights not found!");
            }
        }


        // DELETE api/<FlightController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var flightToBeDeleted = ctx.Flights.Find(id);

            if (flightToBeDeleted != null)
            {
                ctx.Flights.Remove(flightToBeDeleted);

                ctx.SaveChanges();

                return Ok("Flight deleted successfully!");
            }
            else
            {
                return BadRequest("Flight not found!");
            }
        }
    }
}
