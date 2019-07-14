using FluentAssertions;
using MarsRover.ConsoleApp.Commands;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.ConsoleApp.Tests.Commands
{
    public class MoveCommandTest
    {
        [Fact]
        public void CommandMove_Navgite_Rover_To_NorthDirection()
        {
            //Arrange
            MoveCommand command = new MoveCommand();
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, Enums.DirectionEnum.North, startingPosition);

            //Expected
            command.Execute(rover);

           //Actual
            rover.CurrentLocation.Should().Be("1 3 N");
        }
    }
}
