using Contracts;
using System;

namespace Chapter08.MagicIndex
{
    public abstract class BaseSolution : ISolution
    {
        protected readonly int[] Array;

        protected BaseSolution(int[] array)
        {
            this.Array = array;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            foreach (var item in Array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.WriteLine($"GetMagicIndex -> {GetMagicIndex()}");
        }

        protected abstract int GetMagicIndex();
    }
}
