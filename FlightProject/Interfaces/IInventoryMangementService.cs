using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Interfaces
{
    public interface IInventoryMangementService
    {
        void PrintFlightSchedule();
        void GenerateFlightItineraries();
    }
}
