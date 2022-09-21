using Contracts;
using System;

namespace Chapter08.Multiplication
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
            Console.WriteLine($"A: {a}, B: {b}");
            Console.WriteLine($"MinProduct -> {MinProduct(a, b)}");
        }

        private int MinProduct(int a, int b)
        {
            var bigger = a < b ? b : a;
            var smaller = a < b ? a : b;

            return MinProductHelper(smaller, bigger);
        }

        private int MinProductHelper(int smaller, int bigger)
        {
            if (smaller == 0)
            {
                return 0;
            }

            if (smaller == 1)
            {
                return bigger;
            }

            var s = smaller >> 1;
            var halfProduct = MinProductHelper(s, bigger);

            if (smaller % 2 == 0)
            {
                return halfProduct + halfProduct;
            }
            else
            {
                return halfProduct + halfProduct + bigger;
            }
        }
    }
}
