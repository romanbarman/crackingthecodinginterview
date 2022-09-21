using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_11_Cents : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new Cents.Solution(26)
        };

        public override string GetDescription()
        {
            return "Given an unlimited number of coins in denominations of 25, 10, 5 and 1 cent. "
                + "Write code that determines the number of ways in which n cents can be represented.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
