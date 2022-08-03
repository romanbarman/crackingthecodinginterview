using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_03_Magic_Index : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new MagicIndex.Solution1.Solution(new [] { -40, -20, -1, 1, 2, 3, 5, 7, 9, 12, 13 }),
            new MagicIndex.Solution2.Solution(new [] { -10, -5, 2, 2, 2, 3, 4, 7, 9, 12, 13})
        };

        public override string GetDescription()
        {
            return "Let's define a \"magic\" index for the array A[0..n-1] as an index for which the condition A[i]=i is satisfied. "
                + "For a given sorted array that does not contain the same values, "
                + "write a method for finding the \"magic\" index in array A.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
