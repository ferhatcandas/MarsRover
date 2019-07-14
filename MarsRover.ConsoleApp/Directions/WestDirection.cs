using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Directions
{
    public class WestDirection : Direction
    {
        public WestDirection() : base( -1, 0)
        {
        }

        public override DirectionEnum Left() => DirectionEnum.South;

        public override DirectionEnum Right() => DirectionEnum.North;
    }
}
