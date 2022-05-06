using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Backend.Models
{
    public class FlightDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =RAHULANA-VD\\SQL2017; Database = MAJORPROJECT; User Id = sa; Password = cybage@123456");
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
    }
}
