using Chapter01;
using Chapter02;
using Contracts;
using QuestionRunner.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestionRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new ICommand[]
            {
                new RunChapterCommand(1, "Ch 01. Arrays and Strings", typeof(Q1_01_Is_Unique)),
                new RunChapterCommand(2, "Ch 02. Linked Lists", typeof(Q2_01_Remove_Dups)),
                new ExitCommand(3)
            };

            while (true)
            {
                Console.Clear();
                ShowCommands(commands);

                var inputCommand = Console.ReadLine();

                int commandNumber;
                if (!int.TryParse(inputCommand, out commandNumber))
                {
                    Console.WriteLine("Invalid command format!");
                    Console.ReadKey();
                    continue;
                }

                var command = commands.FirstOrDefault(c => c.CommandNumber == commandNumber);

                if (command == null)
                {
                    Console.WriteLine("Invalid command!");
                    Console.ReadKey();
                    continue;
                }

                command.Run();
            }
        }

        private static void ShowCommands(IEnumerable<ICommand> commands)
        {
            foreach (var command in commands)
            {
                Console.WriteLine($"{command.CommandNumber}. {command.Title}");
            }
        }
    }
}
