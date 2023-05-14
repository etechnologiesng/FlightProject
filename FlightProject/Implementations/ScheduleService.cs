using FlightProject.Interfaces;
using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Implementations
{
    public class ScheduleService : IScheduleService
    {
        public Schedule LoadFlightSchedule()
        {

        var flights = new List<Flight>
    {
        // Day 1
        new Flight { Day = 1, Destination = Airport.Toronto, FlightNumber =1 },
        new Flight { Day = 1, Destination = Airport.Calgary, FlightNumber =2 },
        new Flight { Day = 1, Destination = Airport.Vancouver,FlightNumber =3  },
        
        // Day 2
        new Flight { Day = 2, Destination = Airport.Toronto, FlightNumber =4 },
        new Flight { Day = 2, Destination = Airport.Calgary, FlightNumber =5  },
        new Flight { Day = 2, Destination = Airport.Vancouver, FlightNumber =6 },
    };
            var schedule = new Schedule();
            schedule.Flights.AddRange(flights);
            return schedule;
        }
        public void PrintFlightSchedule()
        {
            var scheduledFlights = LoadFlightSchedule();

            foreach (var scheduledFlight in scheduledFlights.Flights)
            {
            Console.WriteLine($"Flight:{scheduledFlight.FlightNumber}, Departure:{scheduledFlight.Departure}, Arrival:{scheduledFlight.Destination}, Day:{scheduledFlight.Day}");
            }
        }
    }
}
