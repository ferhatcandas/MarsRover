using System;
using System.Collections.Generic;
using MarsRover.ConsoleApp.Enums;
using MarsRover.ConsoleApp.Parsers;
using System.Text;
using Xunit;
using FluentAssertions;

namespace MarsRover.ConsoleApp.Tests.Parser
{
    public class DirectionEnumParserTest
    {
        [Fact]
        public void Create_Direction_From_EnumType()
        {
            var direction = DirectionEnum.East.ToDirection();

            direction.Rotation().Should().Be("E");

            direction = DirectionEnum.North.ToDirection();

            direction.Rotation().Should().Be("N");

            direction = DirectionEnum.South.ToDirection();

            direction.Rotation().Should().Be("S");

            direction = DirectionEnum.West.ToDirection();
        }
    }
}
