using System;
using System.Collections.Generic;
using System.Text;

namespace FlightProject.Exceptions
{
    public class FlightOverLoadException : Exception
    {
        public FlightOverLoadException() { }

        public FlightOverLoadException(string message)
            : base(message) { }

        public FlightOverLoadException(string message, Exception inner)
            : base(message, inner) { }
    }
}
