using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Models
{
    public class Order
    {
        public string Destination { get; set; }

        public int Priority
        {
            get
            {
                return int.Parse(OrderNumber.Split('-')[1]);
            }
        }
        public string OrderNumber { get; set; }
        public Flight Flight { get; set; }

        public bool IsNotLoaded()
        {
            return Flight == null;
        }
    }
}
