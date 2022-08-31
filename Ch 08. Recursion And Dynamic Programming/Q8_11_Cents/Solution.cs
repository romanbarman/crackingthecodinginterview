using Contracts;
using System;

namespace Chapter08.Cents
{
    public class Solution : ISolution
    {
        private int originCents;

        public Solution(int cents)
        {
            this.originCents = cents;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Cents: {originCents}");
            Console.WriteLine($"MakeChange -> {MakeChange(originCents)}");
        }

        private int MakeChange(int n)
        {
            var denoms = new[] { 25, 10, 5, 1 };
            var map = new int[n + 1, denoms.Length];

            return MakeChange(n, denoms, 0, map);

        }

        private int MakeChange(int amount, int[] denoms, int index, int[,] map)
        {
            if (map[amount, index] > 0)
            {
                return map[amount, index];
            }

            if (index >= denoms.Length - 1)
            {
                return 1;
            }

            var denomAmount = denoms[index];
            var ways = 0;

            for (int i = 0; i * denomAmount <= amount; i++)
            {
                var amountRemainting = amount - i * denomAmount;
                ways += MakeChange(amountRemainting, denoms, index + 1, map);
            }

            map[amount, index] = ways;
            return ways;
        }
    }
}
