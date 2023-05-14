using FlightProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace FlightProject
{
    public static  class ReadOrdersHelper
    {
        public static Dictionary<string, Order> ReadAllOrders()
        {

            var jsonFile = File.ReadAllText(@"C:\Users\etech\source\repos\FlightProject\FlightProject\FlightOrders.json");
            var serializationOptions = new System.Text.Json.JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var ordersDictionary = JsonSerializer.Deserialize<Dictionary<string, Order>>(jsonFile, serializationOptions);

            return ordersDictionary;
        }
    }
}
