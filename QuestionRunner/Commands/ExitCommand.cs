using Contracts;
using System;

namespace QuestionRunner.Commands
{
    class ExitCommand : ICommand
    {
        public ExitCommand(int commandNumber)
        {
            CommandNumber = commandNumber;
        }

        public int CommandNumber { get; }

        public string Title => "Exit";

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
