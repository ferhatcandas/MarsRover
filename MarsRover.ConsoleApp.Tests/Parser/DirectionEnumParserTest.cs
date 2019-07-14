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
        [Theory]
        [InlineData(DirectionEnum.East,"E")]
        [InlineData(DirectionEnum.West,"W")]
        [InlineData(DirectionEnum.South,"S")]
        [InlineData(DirectionEnum.North,"N")]
        public void Create_Direction_From_EnumType(DirectionEnum directionEnum,string actual)
        {
            directionEnum.ToDirection().Rotation().Should().Be(actual);
        }
    }
}
