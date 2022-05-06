using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCORSPolicy")]
    public class BookingController : ControllerBase
    {
        FlightDbContext ctx = new FlightDbContext();
        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return ctx.Bookings.ToList();
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var bookingToBeSearched = ctx.Bookings.Find(id);

            if (bookingToBeSearched != null)
            {
                return Ok(bookingToBeSearched);
            }
            else
            {
                return BadRequest("Booking not found!");
            }
        }

        // POST api/<BookingController>
        [HttpPost]
        public string Post([FromBody] Booking NewBooking)
        {
            ctx.Bookings.Add(NewBooking);

            ctx.SaveChanges();

            return "Booking added successfully!";
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Booking updatedDetails)
        {
            var bookingToBeUpdated = ctx.Bookings.Find(id);

            if (bookingToBeUpdated != null)
            {
                bookingToBeUpdated.numberofseatstobook = updatedDetails.numberofseatstobook;
                bookingToBeUpdated.boookingdate = updatedDetails.boookingdate;
                bookingToBeUpdated.paystatus = updatedDetails.paystatus;
                bookingToBeUpdated.isrefundable = updatedDetails.isrefundable;
             
                ctx.SaveChanges();
                return Ok("Booking updated successfully!");
            }
            else
            {
                return BadRequest("Booking not found!");
            }
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var bookingToBeDeleted = ctx.Bookings.Find(id);

            if (bookingToBeDeleted != null)
            {
                ctx.Bookings.Remove(bookingToBeDeleted);

                ctx.SaveChanges();

                return Ok("Booking deleted successfully!");
            }
            else
            {
                return BadRequest("Booking not found!");
            }
        }
    }
}
