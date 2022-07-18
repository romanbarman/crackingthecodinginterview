using Contracts;
using System;

namespace Chapter05.FindMaxSequenceLength
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
            Console.WriteLine($"Number: {Convert.ToString(number, 2)}");
            Console.WriteLine($"FindMaxLength -> {FindMaxLength()}");
        }

        private int FindMaxLength()
        {
            if (~number == 0)
            {
                return 32;
            }

            var currentLength = 0;
            var previosLength = 0;
            int maxLength = 0;

            while (number != 0)
            {
                if ((number & 1) == 1)
                {
                    currentLength++;
                }
                else
                {
                    previosLength = (number & 2) == 0 ? 0 : currentLength;
                    currentLength = 0;
                }
                maxLength = Math.Max(previosLength + currentLength + 1, maxLength);
                number = (int)((uint)number >> 1);
            }

            return maxLength;
        }
    }
}
