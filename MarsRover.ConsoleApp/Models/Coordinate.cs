using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Models
{
    public class Coordinate
    {
        public Coordinate(int x, int y)
        {
            xCoordinate = x;
            yCoordinate = y;
        }
        private int xCoordinate { get; set; }
        private int yCoordinate { get; set; }
        public override string ToString() => $"{xCoordinate} {yCoordinate}";
        public bool HasWithinBounds(Coordinate coordinate) => IsXCoordinateWithinBounds(coordinate.xCoordinate) && IsYCoordinateWithinBounds(coordinate.yCoordinate);

        public bool HasOutsideBounds(Coordinate Coordinate) => IsXCoordinateInOutsideBounds(Coordinate.xCoordinate) && IsYCoordinateInOutsideBounds(Coordinate.yCoordinate);

        private bool IsXCoordinateInOutsideBounds(int xCoordinate) => xCoordinate >= this.xCoordinate;

        private bool IsYCoordinateInOutsideBounds(int yCoordinate) => yCoordinate >= this.yCoordinate;

        private bool IsYCoordinateWithinBounds(int yCoordinate) => yCoordinate <= this.yCoordinate;

        private bool IsXCoordinateWithinBounds(int xCoordinate) => xCoordinate <= this.xCoordinate;
        /// <summary>
        /// change's coordinate step size to movement
        /// </summary>
        /// <param name="xCoordinatetepValue"></param>
        /// <param name="yCoordinatetepValue"></param>
        /// <returns></returns>
        public Coordinate NewCoordinateForStepSize(int xCoordinatetepValue, int yCoordinatetepValue) => new Coordinate(xCoordinate + xCoordinatetepValue, yCoordinate + yCoordinatetepValue);

    }
}
