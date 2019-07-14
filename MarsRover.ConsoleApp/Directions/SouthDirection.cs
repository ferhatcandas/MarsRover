using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Directions
{
    public class SouthDirection : Direction
    {
        public SouthDirection() : base( 0, -1)
        {
        }

        public override DirectionEnum Left() => DirectionEnum.East;

        public override DirectionEnum Right() => DirectionEnum.West;
    }
}
