using Contracts;
using System.Collections.Generic;

namespace Chapter05
{
    public class Q5_01_Insert_Bits : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new InsertBits.Solution(0b10000000000, 0b10011, 2, 6)
        };

        public override string GetDescription()
        {
            return "Given two 32-bit numbers N and M, and two bit positions i and j. "
                + "Write a method to insert N into M so that M is in bit position j through bit i.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
