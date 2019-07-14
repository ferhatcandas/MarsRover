using MarsRover.ConsoleApp.Directions;
using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Parser
{
    public static class DirectionEnumParser
    {
        public static Direction ToDirection(this DirectionEnum directionEnum)
        {
            switch (directionEnum)
            {
                case DirectionEnum.North:
                    return new NorthDirection();
                case DirectionEnum.South:
                    return new SouthDirection();
                case DirectionEnum.East:
                    return new EastDirection();
                case DirectionEnum.West:
                    return new WestDirection();
                default:
                    throw new ArgumentException(nameof(directionEnum));
            }
        }
    }
}
