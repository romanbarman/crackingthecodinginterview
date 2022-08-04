using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_05_Multiplication : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new Multiplication.Solution(11, 7)
        };

        public override string GetDescription()
        {
            return "Write a recursive function to multiply two positive integers without using the * operator. "
                + "It is allowed to use addition, subtraction and bitwise shift operations, but their number should be minimal.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
