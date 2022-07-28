using Contracts;
using System.Collections.Generic;

namespace Chapter07
{
    public class Q7_09_Circular_Array : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new CircularArray.Solution()
        };

        public override string GetDescription()
        {
            return "Implement the CircularArray class to represent data structures - "
                + "analogous to an array with an efficient implementation of the cyclic shift.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
