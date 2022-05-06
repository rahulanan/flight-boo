using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
    }
}
