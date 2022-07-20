using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_04_Find_Next_Prev : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new FindNextPrev.Solution(13948)
        };

        public override string GetDescription()
        {
            return "For a given positive number, "
                + "print the nearest smallest and largest numbers that have the same number of 1 bits in binary representation.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
