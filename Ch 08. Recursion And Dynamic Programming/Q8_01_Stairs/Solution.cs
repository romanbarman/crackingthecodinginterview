using Contracts;
using System;

namespace Chapter08.Stairs
{
    public class Solution : ISolution
    {
        private int n;

        public Solution(int n)
        {
            this.n = n;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Number of steps: {n}");
            Console.WriteLine($"CountWays -> {CountWays()}");
        }

        private int CountWays()
        {
            var memo = new int[n + 1];
            Array.Fill(memo, -1);

            return CountWays(n, memo);
        }

        private static int CountWays(int i, int[] memo)
        {
            if (i < 0)
            {
                return 0;
            }

            if (i == 0)
            {
                return 1;
            }

            if (memo[i] > -1)
            {
                return memo[i];
            }

            memo[i] = CountWays(i - 1, memo) + CountWays(i - 2, memo) + CountWays(i - 3, memo);

            return memo[i];
        }
    }
}
