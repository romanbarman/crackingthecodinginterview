﻿using Chapter01;
using Contracts;
using System;

namespace QuestionRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var chapter01Questions = new IQuestion[]
            {
                new Q1_01_Is_Unique(),
                new Q1_02_Check_Permutation(),
                new Q1_03_URLify()
            };

            foreach (var question in chapter01Questions)
            {
                Console.WriteLine(question.GetDescription());
                Console.WriteLine();
                question.Run();

                Console.WriteLine(new string('-', 120));
            }
        }
    }
}
