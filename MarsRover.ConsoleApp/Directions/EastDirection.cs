using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Directions
{
    public class EastDirection : Direction
    {
        public EastDirection() : base( 1, 0)
        {
        }

        public override DirectionEnum Left() => DirectionEnum.North;

        public override DirectionEnum Right() => DirectionEnum.South;
    }
}
