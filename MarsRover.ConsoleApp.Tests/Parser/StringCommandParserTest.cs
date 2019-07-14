using FluentAssertions;
using MarsRover.ConsoleApp.Commands;
using MarsRover.ConsoleApp.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MarsRover.ConsoleApp.Tests.Parser
{
    public class StringCommandParserTest
    {

        [Theory]
        [InlineData("L", typeof(RotateLeftCommand), 1)]
        [InlineData("R", typeof(RotateRightCommand), 1)]
        [InlineData("M", typeof(MoveCommand), 1)]
        public void String_MapsTo_RotateCommands(string command, Type rotateType, int actualCount)
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser(command);

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(rotateType);
            commands.Count().Should().Be(actualCount);
        }
        [Theory]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void NullOrEmptyString_Results_CommandList(string command, int actualCount)
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser(command);

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.Count().Should().Be(actualCount);

        }

        [Fact]
        public void String_ToCommand_MappingIs_CaseInsensitive()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("mM");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(typeof(MoveCommand));
            commands.ElementAt(1).GetType().Should().Be(typeof(MoveCommand));
            commands.Count().Should().Be(2);
        }

        [Fact]
        public void Multi_CommandString_IsMapped_ToCommands_InSameOrder()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("MRL");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(typeof(MoveCommand));
            commands.ElementAt(1).GetType().Should().Be(typeof(RotateRightCommand));
            commands.ElementAt(2).GetType().Should().Be(typeof(RotateLeftCommand));
            commands.Count().Should().Be(3);
        }

    }
}
