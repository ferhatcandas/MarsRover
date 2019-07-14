using MarsRover.ConsoleApp.Models;
using System;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            Coordinate coordinate = new Coordinate(1, 2);
            Rover rover1 = new Rover(plateau,Enums.DirectionEnum.North, coordinate);
            rover1.Run("LMLMLMLMM");
            // 1 3 N
            Console.WriteLine(rover1.CurrentLocation);


            Coordinate coordinate2 = new Coordinate(3,3);
            Rover rover2 = new Rover(plateau, Enums.DirectionEnum.East, coordinate2);
            rover2.Run("MMRMMRMRRM");
            //5 1 E
            Console.WriteLine(rover2.CurrentLocation);

            Console.ReadKey();
        }
    }
}
