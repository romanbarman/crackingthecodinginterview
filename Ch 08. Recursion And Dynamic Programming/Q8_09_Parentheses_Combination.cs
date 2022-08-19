using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_09_Parentheses_Combination : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new ParenthesesCombination.Solution(4)
        };

        public override string GetDescription()
        {
            return "Implement an algorithm to print all valid (properly open and closed) combinations of n pairs of parentheses.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
