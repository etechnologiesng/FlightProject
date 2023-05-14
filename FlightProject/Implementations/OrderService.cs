using FlightProject.Exceptions;
using FlightProject.Interfaces;
using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightProject.Implementations
{
    public class OrderService : IOrderService
    {
        public   const int MAX_LOAD_CAPACITY =  20;
        public List<Order> GetAllOrders()
        {
            var orderdict = ReadOrdersHelper.ReadAllOrders();
            var orders = orderdict?.Select((kv, index) => new Order
            {         
                OrderNumber = kv.Key,
                Destination = kv.Value.Destination,
            });
            return orders.ToList();
        }

        public void LoadOrderToFlight(Flight flight, Order order)
        {         
            if(flight.Orders.Count > MAX_LOAD_CAPACITY)
                throw new FlightOverLoadException($"Flight-{flight.FlightNumber} has reached maximum load capacity");

            order.Flight = flight;
        }
    }
}
