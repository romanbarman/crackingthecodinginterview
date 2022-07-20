using Contracts;
using System;

namespace Chapter05.FindDifferenceCount
{
    public class Solution : ISolution
    {
        private int a;
        private int b;

        public Solution(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"A: {a} -> {Convert.ToString(a, 2)}");
            Console.WriteLine($"B: {b} -> {Convert.ToString(b, 2)}");
            Console.WriteLine($"CountBitsDif -> {CountBitsDif()}");
        }

        private int CountBitsDif()
        {
            var count = 0;
            for (var i = a ^ b; i != 0 ; i = i >> 1)
            {
                count += i & 1;
            }

            return count;
        }
    }
}
