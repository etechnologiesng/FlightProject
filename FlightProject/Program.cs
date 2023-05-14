using FlightProject.Implementations;
using FlightProject.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FlightProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           
            .AddTransient<IOrderService, OrderService>()
            .AddTransient<IScheduleService, ScheduleService>()
             .AddTransient<IInventoryMangementService, InventoryMangementService>()
            .BuildServiceProvider();
            var solution = serviceProvider.GetService<IInventoryMangementService>();
            solution.PrintFlightSchedule();
            solution.GenerateFlightItineraries();
            Console.ReadKey();

        }
    }
}
