using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_07_Change_Bits : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new ChangeBits.Solution(0b1001001)
        };

        public override string GetDescription()
        {
            return "Write a program that swaps even and odd bits of a number with as few instructions as possible.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
