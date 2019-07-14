using FluentAssertions;
using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Exception;
using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.ConsoleApp.Tests.Models
{
    public class RoverTest
    {
        [Fact]
        public void Rover_should_provide_CurrentLocationAsString()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(3, 3);

            //Expected
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Actual
            rover.CurrentLocation.Should().Be("3 3 N");
        }



        [Fact]
        public void Rover_can_should_rotate_left()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.TurnLeft();

            //Actual
            rover.CurrentLocation.Should().Be("1 2 W");
        }

        [Fact]
        public void Rover_can_should_rotate_right()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.TurnRight();

            //Actual
            rover.CurrentLocation.Should().Be("1 2 E");
        }

        [Fact]
        public void Rover_can_move()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.Move();

            //Actual
            rover.CurrentLocation.Should().Be("1 3 N");
        }

        [Fact]
        public void Rover_can_run_CommandToRotateRight()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.Run("R");

            //Actual
            rover.CurrentLocation.Should().Be("1 2 E");
        }

        [Fact]
        public void Rover_can_run_CommandToRotateLeft()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.Run("L");

            //Actual
            rover.CurrentLocation.Should().Be("1 2 W");
        }

        [Fact]
        public void Rover_can_run_CommandToMove()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(1, 2);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Expected
            rover.Run("M");

            //Actual
            rover.CurrentLocation.Should().Be("1 3 N");
        }

        [Fact]
        public void Rover_can_run_CommandWithMultipleInstructions()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(3, 3);
            Rover rover = new Rover(plateau, DirectionEnum.East, startingPosition);

            //Expected
            rover.Run("MMRMMRMRRM");

            //Actual
            rover.CurrentLocation.Should().Be("5 1 E");
        }

        [Fact]
        public void Rover_should_throws_exception_when_commands_outOfPlateau()
        {
            //Arrange
            Plateau plateau = new Plateau(5, 5);
            Coordinate startingPosition = new Coordinate(3, 3);
            Rover rover = new Rover(plateau, DirectionEnum.North, startingPosition);

            //Actual
            Assert.Throws<CoordinatesOutOfRangeException>(() =>
            {
                rover.Run("MMMMMMMMMMR");

            });
            
        }
    }
}
