using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int numberofseatstobook { get; set; }
        public DateTime boookingdate { get; set; }
        public string paystatus { get; set; }
        public int isrefundable { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
    }
}
