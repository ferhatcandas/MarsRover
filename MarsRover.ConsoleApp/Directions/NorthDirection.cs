using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Directions
{
    public class NorthDirection : Direction
    {
        public NorthDirection() : base(0, 1)
        {
        }

        public override DirectionEnum Left() => DirectionEnum.West;

        public override DirectionEnum Right() => DirectionEnum.East;
    }
}
