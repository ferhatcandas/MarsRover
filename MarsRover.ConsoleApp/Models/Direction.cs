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
        /// <summary>
        /// step size to move x coordinate direction
        /// </summary>
        public int StepsizeOnXAxis { get; private set; }
        /// <summary>
        /// step size to move y coordinate direction
        /// </summary>
        public int StepsizeOnYAxis { get; private set; }
        public abstract DirectionEnum Right();
        public abstract DirectionEnum Left();
        public string Rotation() => this.GetType().Name.Substring(0, 1);
    }
}
