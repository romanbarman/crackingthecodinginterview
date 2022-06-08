using Chapter01;
using Chapter02;
using Contracts;
using System;

namespace QuestionRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var questions = new IQuestion[]
            {
                new Q1_01_Is_Unique(),
                new Q1_02_Check_Permutation(),
                new Q1_03_URLify(),
                new Q1_04_Palindrome_Permutation(),
                new Q1_05_One_Away_A(),
                new Q1_06_String_Compression(),
                new Q1_07_Rotate_Matrix(),
                new Q1_08_Zero_Matrix(),
                new Q1_09_String_Rotation(),
                new Q2_01_Remove_Dups(),
                new Q2_02_Return_Kth_To_Last(),
                new Q2_03_Delete_Middle_Node(),
                new Q2_04_Partition(),
                new Q2_05_Sum_Lists(),
                new Q2_06_Palindrome()
            };

            foreach (var question in questions)
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
