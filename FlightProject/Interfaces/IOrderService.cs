using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();

        void LoadOrderToFlight(Flight flight, Order order);
    }
}
