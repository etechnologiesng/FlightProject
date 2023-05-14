using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Models
{
    public  class Schedule
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
    }
}
