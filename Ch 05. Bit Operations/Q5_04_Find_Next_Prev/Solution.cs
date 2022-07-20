using Contracts;
using System;

namespace Chapter05.FindNextPrev
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

            var next = GetNext(number);
            var prev = GetPrev(number);

            Console.WriteLine($"Next: {next} -> {Convert.ToString(next, 2)}");
            Console.WriteLine($"Prev: {prev} -> {Convert.ToString(prev, 2)}");
        }

        private static int GetNext(int n)
        {
            var c = n;
            var c0 = 0;
            var c1 = 0;

            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            if (c0 + c1 == 31 || c0 + c1 == 0)
            {
                return -1;
            }

            var p = c0 + c1;
            n |= (1 << p);
            n &= ~((1 << p) - 1);
            n |= (1 << (c1 - 1)) - 1;
            return n;
        }

        private static int GetPrev(int n)
        {
            var c = n;
            var c0 = 0;
            var c1 = 0;

            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            var p = c0 + c1;
            n &= ((~0) << (p + 1));

            var mask = (1 << (c1 + 1)) - 1;
            n |= mask << (c0 - 1);

            return n;
        }
    }
}
