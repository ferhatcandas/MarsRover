using MarsRover.ConsoleApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.ConsoleApp.Parsers
{
    public class StringCommandParser
    {
        private static Dictionary<string, ICommand> StringToCommandMap = new Dictionary<string, ICommand>();
        public string CommandString { get; set; }
        public StringCommandParser(string commandString)
        {
            CommandString = commandString ?? "";
            SetCommands();
        }

        public List<ICommand> ToCommands()
        {
            if (string.IsNullOrEmpty(CommandString.Trim())) return new List<ICommand>();
            return BuildCommandsList(CommandString);
        }

        private List<ICommand> BuildCommandsList(string commandString)
        {
            List<ICommand> commands = new List<ICommand>();
            if (CommandString != null)
            {
                string[] commandChars = CommandCharactersFrom(commandString);

                foreach (string commandCharacter in commandChars)
                {
                    if (commandCharacter == null) break;
                    ICommand mappedCommand = LookupEquivalentCommand(commandCharacter.ToUpper());
                    commands.Add(mappedCommand);
                }
            }

            return commands;
        }
        private string[] CommandCharactersFrom(string commandString)
        {
            string[] stringArray = commandString.ToCharArray().Select(c => c.ToString()).ToArray();
            return stringArray.Skip(0).Take(commandString.Length + 1).ToArray();
        }

        private ICommand LookupEquivalentCommand(string commandString) => StringToCommandMap[commandString];

        private void SetCommands()
        {
            if (StringToCommandMap.Count == 0)
            {
                StringToCommandMap.Add("L", new RotateLeftCommand());
                StringToCommandMap.Add("R", new RotateRightCommand());
                StringToCommandMap.Add("M", new MoveCommand());
            }
        }

    }
}
