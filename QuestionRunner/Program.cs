using Chapter01;
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
                new Q1_03_URLify(),
                new Q1_04_Palindrome_Permutation(),
                new Q1_05_One_Away_A(),
                new Q1_06_String_Compression(),
                new Q1_07_Rotate_Matrix(),
                new Q1_08_Zero_Matrix(),
                new Q1_09_String_Rotation()
            };

            foreach (var question in chapter01Questions)
            {
                Console.WriteLine(question.GetDescription());
                Console.WriteLine();
                question.Run();

                Console.WriteLine(new string('-', 120));
                Console.WriteLine();
            }
        }
    }
}
