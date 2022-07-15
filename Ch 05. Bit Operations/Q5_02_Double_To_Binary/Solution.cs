using Contracts;
using System;
using System.Text;

namespace Chapter05.DoubleToBinary
{
    public class Solution : ISolution
    {
        private readonly double[] numbers;

        public Solution(double[] numbers)
        {
            this.numbers = numbers;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"Number = {number}");
                Console.WriteLine($"ToBinary -> {ToBinary(number)}");
                Console.WriteLine();
            }
        }

        public string ToBinary(double number)
        {
            var sb = new StringBuilder();
            sb.Append(".");

            for (int i = 0; i < 32; i++)
            {
                if (number == 0)
                {
                    return sb.ToString();
                }

                number = number * 2;

                if (number >= 1)
                {
                    sb.Append("1");
                    number = number - 1;
                }
                else
                {
                    sb.Append("0");
                }
            }

            return "Error";
        }
    }
}
