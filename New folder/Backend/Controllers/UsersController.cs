using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCORSPolicy")]
    public class UsersController : ControllerBase
    {
        FlightDbContext ctx = new FlightDbContext();
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return ctx.Users.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var userToBeSearched = ctx.Users.Find(id);

            if (userToBeSearched != null)
            {
                return Ok(userToBeSearched);
            }
            else
            {
                return BadRequest("User not found!");
            }
        }

        // POST api/<UsersController>
        [HttpPost]
        public string Post([FromBody] User NewUser)
        {
            ctx.Users.Add(NewUser);

            ctx.SaveChanges();

            return "User added successfully!";
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User updatedDetails)
        {
            var userToBeUpdated = ctx.Users.Find(id);

            if (userToBeUpdated != null)
            {
                userToBeUpdated.FirstName = updatedDetails.FirstName;
                userToBeUpdated.MiddleName = updatedDetails.MiddleName;
                userToBeUpdated.LastName = updatedDetails.LastName;
                userToBeUpdated.UserName = updatedDetails.UserName;
                userToBeUpdated.isadmin = updatedDetails.isadmin;
                userToBeUpdated.Email = updatedDetails.Email;
                userToBeUpdated.Password = updatedDetails.Password;
                userToBeUpdated.Age = updatedDetails.Age;
                userToBeUpdated.Gender = updatedDetails.Gender;
                userToBeUpdated.Phoneno = updatedDetails.Phoneno;
                userToBeUpdated.Address = updatedDetails.Address;
                userToBeUpdated.City = updatedDetails.City;
                userToBeUpdated.Pincode = updatedDetails.Pincode;
                userToBeUpdated.State = updatedDetails.State;
               
                ctx.SaveChanges();
                return Ok("User updated successfully!");
            }
            else
            {
                return BadRequest("User not found!");
            }
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var userToBeDeleted = ctx.Users.Find(id);

            if (userToBeDeleted != null)
            {
                ctx.Users.Remove(userToBeDeleted);

                ctx.SaveChanges();

                return Ok("User deleted successfully!");
            }
            else
            {
                return BadRequest("User not found!");
            }
        }
    }
}
