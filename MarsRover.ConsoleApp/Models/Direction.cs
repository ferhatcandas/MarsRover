using MarsRover.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.ConsoleApp.Models
{
    public abstract class Direction
    {
        public Direction(int stepSizeOnXAxis, int stepSizeOnYAxis)
        {
            StepsizeOnXAxis = stepSizeOnXAxis;
            StepsizeOnYAxis = stepSizeOnYAxis;
        }
        public int StepsizeOnXAxis { get; private set; }
        public int StepsizeOnYAxis { get; private set; }
        public abstract DirectionEnum Right();
        public abstract DirectionEnum Left();
        public string Rotation() => this.GetType().Name.FirstOrDefault().ToString();
    }
}
