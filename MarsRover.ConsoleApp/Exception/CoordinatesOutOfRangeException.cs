using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Exception
{
    public class CoordinatesOutOfRangeException : System.Exception
    {
        public CoordinatesOutOfRangeException() : base("Entered coordinates is out of plateau.")
        {

        }
    }
}
