using FluentAssertions;
using MarsRover.ConsoleApp.Commands;
using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.ConsoleApp.Tests.Commands
{
    public class RotateRightCommandTest
    {
        [Fact]
        public void RotateRight_ChangeDirection_Rover_To_EastDirection()
        {
            //Arrange
            RotateRightCommand command = new RotateRightCommand();
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            command.Execute(rover);

           //Actual
            rover.CurrentLocation.Should().Be("1 2 E");
        }
    }
}
