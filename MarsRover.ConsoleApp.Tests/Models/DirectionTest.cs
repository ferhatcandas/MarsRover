using FluentAssertions;
using MarsRover.ConsoleApp.Directions;
using MarsRover.ConsoleApp.Models;
using MarsRover.ConsoleApp.Parsers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MarsRover.ConsoleApp.Enums;

namespace MarsRover.ConsoleApp.Tests.Models
{
    public class DirectionTest
    {
        [Fact]
        public void WestDirection_IsOn_LeftOf_NorthDirection()
        {
            //Arrange
            Direction north = DirectionEnum.North.ToDirection();

            //Expected
            Direction west = north.Left().ToDirection();

            //Actual
            west.GetType().Should().Be(typeof(WestDirection));
        }

        [Fact]
        public void EastDirection_IsOn_RightOf_NorthDirection()
        {
            //Arrange
            Direction north = DirectionEnum.North.ToDirection();

            //Expected
            Direction east = north.Right().ToDirection();

            //Actual
            east.GetType().Should().Be(typeof(EastDirection));

        }

        [Fact]
        public void NorthDirection_IsOn_RightOf_WestDirection()
        {
            //Arrange
            Direction west = DirectionEnum.West.ToDirection();

            //Expected
            Direction north = west.Right().ToDirection();

            //Actual
            north.GetType().Should().Be(typeof(NorthDirection));
        }

        [Fact]
        public void SouthDirection_IsOn_LeftOf_WestDirection()
        {
            //Arrange
            Direction west = DirectionEnum.West.ToDirection();

            //Expected
            Direction south = west.Left().ToDirection();

            //Actual
            south.GetType().Should().Be(typeof(SouthDirection));

        }

        [Fact]
        public void EastDirection_IsOn_LeftOf_SouthDirection()
        {
            //Arrange
            Direction south = DirectionEnum.South.ToDirection();

            //Expected
            Direction east = south.Left().ToDirection();

            //Actual
            east.GetType().Should().Be(typeof(EastDirection));

        }

        [Fact]
        public void WestDirection_IsOn_RightOf_SouthDirection()
        {
            //Arrange
            Direction south = DirectionEnum.South.ToDirection();

            //Expected
            Direction west = south.Right().ToDirection();

            //Actual
            west.GetType().Should().Be(typeof(WestDirection));

        }

        [Fact]
        public void NorthDirection_IsOn_LeftOf_EastDirection()
        {
            //Arrange
            Direction east = DirectionEnum.East.ToDirection();

            //Expected
            Direction north = east.Left().ToDirection();

            //Actual
            north.GetType().Should().Be(typeof(NorthDirection));

        }

        [Fact]
        public void SouthDirection_IsOn_RightOf_EastDirection()
        {
            //Arrange
            Direction east = DirectionEnum.East.ToDirection();

            //Expected
            Direction south = east.Right().ToDirection();

            //Actual
            south.GetType().Should().Be(typeof(SouthDirection));

        }

        [Fact]
        public void EastDirection_Is_OneStep_Forward_OnXAxis()
        {
            //Arrange
            Direction east = DirectionEnum.East.ToDirection();

            //Expected
            int stepSize = east.StepsizeOnXAxis;

            //Actual
            stepSize.Should().Be(1);

        }

        [Fact]
        public void EastDirection_IsStationary_OnYAxis()
        {

            //Arrange
            Direction east = DirectionEnum.East.ToDirection();

            //Expected
            int stepSize = east.StepsizeOnYAxis;

            //Actual
            stepSize.Should().Be(0);

        }

        [Fact]
        public void WestDirection_Is_OneStepBack_OnXAxis()
        {

            //Arrange
            Direction west = DirectionEnum.West.ToDirection();

            //Expected
            int stepSize = west.StepsizeOnXAxis;

            //Actual
            stepSize.Should().Be(-1);

        }


        [Fact]
        public void WestDirection_IsStationary_OnYAxis()
        {
            //Arrange
            Direction west = DirectionEnum.West.ToDirection();

            //Expected
            int stepSize = west.StepsizeOnYAxis;

            //Actual
            stepSize.Should().Be(0);

        }

        [Fact]
        public void NorthDirection_IsOne_StepForward_OnYAxis()
        {
            //Arrange
            Direction north = Enums.DirectionEnum.North.ToDirection();

            //Expected
            int stepSize = north.StepsizeOnYAxis;

            //Actual
            stepSize.Should().Be(1);

        }


        [Fact]
        public void NorthDirection_IsStationary_OnXAxis()
        {
            //Arrange
            Direction north = Enums.DirectionEnum.North.ToDirection();

            //Expected
            int stepSize = north.StepsizeOnXAxis;

            //Actual
            stepSize.Should().Be(0);

        }

        [Fact]
        public void SouthDirection_IsOne_StepBack_OnYAxis()
        {

            //Arrange
            Direction south = DirectionEnum.South.ToDirection();

            //Expected
            int stepSize = south.StepsizeOnYAxis;

            //Actual
            stepSize.Should().Be(-1);

        }

        [Fact]
        public void SouthDirection_IsStationary_OnXAxis()
        {

            //Arrange
            Direction south = DirectionEnum.South.ToDirection();

            //Expected
            int stepSize = south.StepsizeOnXAxis;

            //Actual
            stepSize.Should().Be(0);

        }
    }
}
