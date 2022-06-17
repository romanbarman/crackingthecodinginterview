using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter01.IsUnique
{
    public abstract class BaseSolution : ISolution
    {
        private IEnumerable<string> strCollection;

        protected BaseSolution(IEnumerable<string> strCollection)
        {
            this.strCollection = strCollection;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            foreach (var str in strCollection)
            {
                Console.WriteLine($"String '{str}': IsUniqueChars -> {IsUniqueChars(str)}");
            }
        }

        protected abstract bool IsUniqueChars(string str);
    }
}
