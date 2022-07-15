using Contracts;
using System;

namespace Chapter05.InsertBits
{
    public class Solution : ISolution
    {
        private int n;
        private int m;
        private int i;
        private int j;

        public Solution(int n, int m, int i, int j)
        {
            this.n = n;
            this.m = m;
            this.i = i;
            this.j = j;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"N = {Convert.ToString(n, 2)}");
            Console.WriteLine($"M = {Convert.ToString(m, 2)}");
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"UpdateBits -> {Convert.ToString(UpdateBits(), 2)}");
        }

        private int UpdateBits()
        {
            var allOnes = ~0;
            var left = allOnes << (j + 1);
            var right = ((1 << i) - 1);
            var mask = left | right;
            var nCleared = n & mask;
            var mShifted = m << i;
            return nCleared | mShifted;
        }
    }
}
