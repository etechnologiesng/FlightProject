using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Models
{
    public class Flight
    {
        public int FlightNumber { get; set; }
        public string Departure
        {
            get
            {
                return "YUL";
            }
        }
        public string Destination { get; set; }
        public int Day { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
