using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Backend.Models;



namespace FlightBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCORSPolicy")]
    public class PassengerController : ControllerBase
    {
        FlightDbContext ctx = new FlightDbContext();
        // GET: api/<PassengerController>
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {
            return ctx.Passengers.ToList();
        }

        // GET api/<PassengerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var passengerToBeSearched = ctx.Passengers.Find(id);
            if (passengerToBeSearched != null)
            {
                return Ok(passengerToBeSearched);
            }
            else
            {
                return BadRequest("Passenger not found!");
            }
        }

        // POST api/<PassengerController>
        [HttpPost]
        public string Post([FromBody] Passenger NewPassenger)
        {
            ctx.Passengers.Add(NewPassenger);

            ctx.SaveChanges();

            return "Passenger added successfully!";
        }

        // PUT api/<PassengerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Passenger updateDetails)
        {
            var passengerToBeUpdated = ctx.Passengers.Find(id);

            if (passengerToBeUpdated != null)
            {
                passengerToBeUpdated.PassengerID = passengerToBeUpdated.PassengerID;
                passengerToBeUpdated.PassengerName = passengerToBeUpdated.PassengerName;
                passengerToBeUpdated.Gender = passengerToBeUpdated.Gender;
                passengerToBeUpdated.Age = passengerToBeUpdated.Age;

                ctx.SaveChanges();

                return Ok("Passenger Updated successfully!");
            }
            else
            {
                return BadRequest("Passenger not found!");
            }

        }

        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var passengerToBeDeleted = ctx.Passengers.Find(id);

            if (passengerToBeDeleted != null)
            {
                ctx.Passengers.Remove(passengerToBeDeleted);

                ctx.SaveChanges();

                return Ok("Passenger deleted successfully!");

            }
            else
            {
                return BadRequest("Passenger not found!");
            }
        }
    }
}