using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime Departure { get; set; }
        public double Price { get; set; }
        public int AvailableSeats { get; set; }
        public int TotalSeats { get; set; }

        public Booking Booking { get; set; }
    }
}
