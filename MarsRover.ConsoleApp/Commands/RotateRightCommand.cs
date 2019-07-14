using System;
using System.Collections.Generic;
using System.Text;
using MarsRover.ConsoleApp.Models;

namespace MarsRover.ConsoleApp.Commands
{
    public class RotateRightCommand : ICommand
    {
        public void Execute(Rover rover) => rover.TurnRight();
    }
}
