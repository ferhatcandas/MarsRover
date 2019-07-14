using MarsRover.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.ConsoleApp.Commands
{
    public interface ICommand
    {
        void Execute(Rover rover);
    }
}
