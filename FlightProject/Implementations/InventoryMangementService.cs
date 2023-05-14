using FlightProject.Interfaces;
using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightProject.Implementations
{
    public class InventoryMangementService: IInventoryMangementService
    {
        public readonly IOrderService _orderService;
        public readonly IScheduleService _scheduleService;
        public InventoryMangementService(IOrderService orderService, IScheduleService scheduleService)
        {
            _orderService = orderService;
            _scheduleService = scheduleService;
        }
        public void GenerateFlightItineraries()
        {
            var scheduledFlights = _scheduleService.LoadFlightSchedule();
            var allOrders = _orderService.GetAllOrders();
            List<Order> loadedOrders = new List<Order>();

            foreach (var flight in scheduledFlights.Flights)
            {
                var ordersToBeLoaded = allOrders.Where(x => x.IsNotLoaded() && x.Destination == flight.Destination).OrderBy(x => x.Priority).Take(20).ToList();

                foreach (var order in ordersToBeLoaded)
                {
                    _orderService.LoadOrderToFlight(flight,order);

                    Console.WriteLine($"order:{order.OrderNumber},flightnumber:{order.Flight.FlightNumber}, departure:{order.Flight.Departure}, arrival:{order.Flight.Destination}, day:{order.Flight.Day}");

                    loadedOrders.Add(order);
                }
            }

            var unloadedOrders = allOrders.Except(loadedOrders);

            foreach (var item in unloadedOrders)
            {
                Console.WriteLine($"order:{item.OrderNumber}, destination:{item.Destination}, flightnumber:not scheduled");
            }

        }

        public void PrintFlightSchedule()
        {
            _scheduleService.PrintFlightSchedule();
        }
    }
}
