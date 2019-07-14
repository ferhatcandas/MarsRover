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
        [Fact]
        public void String_LMapsTo_RotateLeftCommand()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("L");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(typeof(RotateLeftCommand));
            commands.Count().Should().Be(1);
        }
        [Fact]
        public void String_RMapsTo_RotateRightCommand()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("R");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(typeof(RotateRightCommand));
            commands.Count().Should().Be(1);
        }
        [Fact]
        public void String_MMapsTo_MoveCommand()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("M");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.ElementAt(0).GetType().Should().Be(typeof(MoveCommand));
            commands.Count().Should().Be(1);
        }
        [Fact]
        public void EmptyStringResults_InEmpty_CommandList()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser("");

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.Count().Should().Be(0);

        }


        [Fact]
        public void NullStringResults_InEmptyCommandList()
        {
            //Arrange
            StringCommandParser parser = new StringCommandParser(null);

            //Expected
            List<ICommand> commands = parser.ToCommands();

            //Actual
            commands.Count().Should().Be(0);
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
