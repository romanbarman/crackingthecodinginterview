using Contracts;
using System;
using System.Linq;

namespace Chapter10.JoinArrays
{
    public class Solution : ISolution
    {
        private int[] main;
        private int[] sub;

        public Solution(int[] main, int[] sub)
        {
            this.main = main;
            this.sub = sub;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array 1: {string.Join(" ", main.Take(main.Length - sub.Length))}");
            Console.WriteLine($"Array 2: {string.Join(" ", sub)}");

            Join();

            Console.WriteLine($"Result: {string.Join(" ", main)}");
        }

        private void Join()
        {
            var currentIndexSub = sub.Length - 1;
            var currentIndexMain = main.Length - sub.Length - 1;
            var currentIndex = main.Length - 1;

            while (currentIndexMain >= 0 && currentIndexSub >= 0)
            {
                if (main[currentIndexMain] >= sub[currentIndexSub])
                {
                    main[currentIndex] = main[currentIndexMain];
                    currentIndexMain--;
                }
                else
                {
                    main[currentIndex] = sub[currentIndexSub];
                    currentIndexSub--;
                }

                currentIndex--;
            }

            if (currentIndexSub >= 0)
            {
                while (currentIndexSub >= 0)
                {
                    main[currentIndex] = sub[currentIndexSub];
                    currentIndexSub--;
                    currentIndex--;
                }
            }
        }
    }
}
