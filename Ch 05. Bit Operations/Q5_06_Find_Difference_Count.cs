using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_06_Find_Difference_Count : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new FindDifferenceCount.Solution(29, 15)
        };

        public override string GetDescription()
        {
            return "Write a function that determines the number of bits that need to be changed "
                + "in order to get an integer B from an integer A.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
