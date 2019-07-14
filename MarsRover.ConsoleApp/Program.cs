using MarsRover.ConsoleApp.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MarsRover.ConsoleApp.Enums;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var provider = new Startup().Init();
            var marsRoverOne = provider.GetService<MarsRoverOne>();
            var marsRoverTwo = provider.GetService<MarsRoverTwo>();

            // 1 3 N
            marsRoverOne.Run("LMLMLMLMM");

            Console.WriteLine(marsRoverOne.CurrentLocation);


            //5 1 E
            marsRoverTwo.Run("MMRMMRMRRM");

            Console.WriteLine(marsRoverTwo.CurrentLocation);

            Console.ReadKey();
        }
    }

    public class PlateauObject : Plateau
    {
        public PlateauObject() : base(5, 5)
        {
        }
    }
    public class CoortinateObjectForRoverOne : Coordinate
    {
        public CoortinateObjectForRoverOne() : base(1, 2)
        {
        }
    }
    public class CoortinateObjectForRoverTwo : Coordinate
    {
        public CoortinateObjectForRoverTwo() : base(3, 3)
        {
        }
    }
    public class MarsRoverOne : Rover
    {
        public MarsRoverOne() : base(new PlateauObject(), DirectionEnum.North, new CoortinateObjectForRoverOne())
        {
        }
    }
    public class MarsRoverTwo : Rover
    {
        public MarsRoverTwo() : base(new PlateauObject(), DirectionEnum.East, new CoortinateObjectForRoverTwo())
        {
        }
    }


    public class Startup
    {
        public ServiceProvider Init()
        {
            ServiceProvider provider = new ServiceCollection()
                .AddSingleton<MarsRoverOne>()
                .AddSingleton<MarsRoverTwo>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
