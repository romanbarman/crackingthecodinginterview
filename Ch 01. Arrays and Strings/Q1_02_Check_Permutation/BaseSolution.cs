using Contracts;
using System;

namespace Chapter01.CheckPermutation
{
    public abstract class BaseSolution : ISolution
    {
        private string[][] pairs;

        protected BaseSolution(string[][] pairs)
        {
            this.pairs = pairs;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair[0]} {pair[1]}: IsPermutation -> {IsPermutation(pair[0], pair[1])}");
            }
        }

        protected abstract bool IsPermutation(string str1, string str2);
    }
}
