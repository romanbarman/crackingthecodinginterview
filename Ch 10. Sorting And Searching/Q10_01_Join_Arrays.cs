using Contracts;
using System.Collections.Generic;

namespace Chapter10
{
    public class Q10_01_Join_Arrays : BaseQuestion
    {
        public override string GetDescription()
        {
            return "There are two sorted arrays A and B. "
                + "There is enough free space at the end of array A to accommodate array B. "
                + "Write a sort-preserving method to merge arrays B and A.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var main = new int[8];
            main[0] = 2;
            main[1] = 4;
            main[2] = 6;
            main[3] = 8;

            var sub = new int[] { 1, 3, 5, 7 };

            return new List<ISolution> { new JoinArrays.Solution(main, sub) };
        }
    }
}
