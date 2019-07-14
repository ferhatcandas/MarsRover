using MarsRover.ConsoleApp.Commands;
using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Exception;
using MarsRover.ConsoleApp.Parsers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Models
{
    public class Rover
    {
        /// <summary>
        /// current coordinate of rover
        /// </summary>
        private Coordinate CurrentCoordinate { get; set; }
        /// <summary>
        /// current direction of rover
        /// </summary>
        private Direction CurrentDirection { get; set; }
        /// <summary>
        /// defined plateau 
        /// </summary>
        private Plateau Plateau { get; set; }

        public Rover(Plateau plateau, DirectionEnum direction, Coordinate coordinate)
        {
            Plateau = plateau;
            CurrentDirection = direction.ToDirection();
            CurrentCoordinate = coordinate;
        }
        /// <summary>
        /// run command's (M,L,R)
        /// M = Movement
        /// R = Turns Right,
        /// L = Turns Left
        /// </summary>
        /// <param name="commandString"></param>
        public void Run(string commandString)
        {
            List<ICommand> roverCommands = new StringCommandParser(commandString).ToCommands();

            foreach (ICommand command in roverCommands)
                command.Execute(this);
        }

        public string CurrentLocation => $"{CurrentCoordinate.ToString()} {CurrentDirection.Rotation()}";
        /// <summary>
        /// rover turn's right
        /// </summary>
        public void TurnRight() => this.CurrentDirection = this.CurrentDirection.Right().ToDirection();
        /// <summary>
        /// rover turn's left
        /// </summary>
        public void TurnLeft() => this.CurrentDirection = this.CurrentDirection.Left().ToDirection();
        /// <summary>
        /// rover move's defined rotation
        /// </summary>
        public void Move()
        {
            Coordinate positionAfterMove = CurrentCoordinate.NewCoordinateForStepSize(CurrentDirection.StepsizeOnXAxis, CurrentDirection.StepsizeOnYAxis);

            //ignores the command if rover is being driven off plateau
            if (Plateau.HasWithinBounds(positionAfterMove))
                CurrentCoordinate = CurrentCoordinate.NewCoordinateForStepSize(CurrentDirection.StepsizeOnXAxis, CurrentDirection.StepsizeOnYAxis);
            else
                throw new CoordinatesOutOfRangeException();
        }
    }
}
