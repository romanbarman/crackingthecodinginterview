using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_14_Logic_Expression : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new LogicExpression.Solution("0&0&0&1^1|0", true)
        };

        public override string GetDescription()
        {
            return "Given a logical expression built from the characters 0, 1, &, | and ^, "
                + "and the desired boolean value of the result. "
                + "Write a function that counts the number of placements in a logical expression of parentheses "
                + "for which the result of the expression is equal to the result.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
