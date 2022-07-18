using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_03_Find_Max_Sequence_Length : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new FindMaxSequenceLength.Solution(0b11011101111)
        };

        public override string GetDescription()
        {
            return "There is an integer in which exactly one bit can be changed from 0 to 1. "
                + "Write code to find the length of the longest sequence of 1's that can be obtained.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
