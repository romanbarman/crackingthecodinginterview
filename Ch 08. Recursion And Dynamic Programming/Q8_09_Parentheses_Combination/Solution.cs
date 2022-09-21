using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.ParenthesesCombination
{
    public class Solution : ISolution
    {
        private int number;

        public Solution(int number)
        {
            this.number = number;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Number: {number}");
            Console.WriteLine();
            Console.WriteLine("Results:");

            foreach (var str in GenerateParens())
            {
                Console.WriteLine(str);
            }
        }

        private List<string> GenerateParens()
        {
            var str = new char[number * 2];
            var result = new List<string>();
            AddParen(result, number, number, str, 0);

            return result;
        }

        private void AddParen(List<string> result, int leftRem, int rightRem, char[] str, int count)
        {
            if (leftRem < 0 || rightRem < leftRem) return;

            if (leftRem == 0 && rightRem == 0)
            {
                result.Add(new string(str));
            }
            else
            {
                if (leftRem > 0)
                {
                    str[count] = '(';
                    AddParen(result, leftRem - 1, rightRem, str, count + 1);
                }
            }

            if (rightRem > leftRem)
            {
                str[count] = ')';
                AddParen(result, leftRem, rightRem - 1, str, count + 1);
            }
        }
    }
}
