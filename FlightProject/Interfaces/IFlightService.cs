using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Interfaces
{
    public interface IFlightService
    {
        List<Order> LoadOrder(Order order);
    }
}
