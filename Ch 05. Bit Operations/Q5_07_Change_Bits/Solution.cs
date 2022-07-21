using Contracts;
using System;

namespace Chapter05.ChangeBits
{
    public class Solution : ISolution
    {
        private int number;

        public Solution(int number) => this.number = number;

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Number: {number} -> {Convert.ToString(number, 2)}");
            Console.WriteLine($"SwapOddEvenBits -> {Convert.ToString(SwapOddEvenBits(number), 2)}");
        }

        private static int SwapOddEvenBits(int x)
        {
            return (int)((uint) (x & 0xaaaaaaaa) >> 1) | ((x & 0x55555555) << 1);
        }
    }
}
