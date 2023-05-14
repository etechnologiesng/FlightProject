using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Interfaces
{
    public  interface IScheduleService
    {
        Schedule LoadFlightSchedule();
        void PrintFlightSchedule();
    }
}
