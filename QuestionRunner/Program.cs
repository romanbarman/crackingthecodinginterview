using Chapter01;
using Chapter02;
using Chapter03;
using Chapter04;
using Chapter05;
using Chapter07;
using Chapter08;
using Chapter10;
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
                new RunChapterCommand(3, "Ch 03. Stack and Queue", typeof(Q3_01_Array_3_Stack)),
                new RunChapterCommand(4, "Ch 04. Trees and Graphs", typeof(Q4_01_Has_Route)),
                new RunChapterCommand(5, "Ch 05. Bit Operations", typeof(Q5_01_Insert_Bits)),
                new RunChapterCommand(6, "Ch 07. OOP", typeof(Q7_01_Card_Deck)),
                new RunChapterCommand(7, "Ch 08. Recursion And Dynamic Programming", typeof(Q8_01_Stairs)),
                new RunChapterCommand(8, "Ch 10. Sorting And Searching", typeof(Q10_01_Join_Arrays)),
                new ExitCommand(9)
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
