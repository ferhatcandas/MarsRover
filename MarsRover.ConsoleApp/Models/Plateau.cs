using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Models
{
    public class Plateau
    {
        /// <summary>
        /// top right corner coordinate's
        /// </summary>
        private Coordinate TopRightCoordinate = new Coordinate(0, 0);
        /// <summary>
        /// botoomleft coordinate's
        /// </summary>
        private Coordinate BottomLeftCoordinate = new Coordinate(0, 0);
        public Plateau(int topRightXCoordinate, int topRightYCoordinate) => this.TopRightCoordinate = this.TopRightCoordinate.NewCoordinateForStepSize(topRightXCoordinate, topRightYCoordinate);
        /// <summary>
        /// defined coordinate checks for current plateau has in bounds
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns></returns>
        public bool HasWithinBounds(Coordinate coordinate) => this.BottomLeftCoordinate.HasOutsideBounds(coordinate) && this.TopRightCoordinate.HasWithinBounds(coordinate);
    }
}
