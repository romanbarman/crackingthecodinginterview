using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_01_Stairs : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new Stairs.Solution(10)
        };

        public override string GetDescription()
        {
            return "The child climbs the stairs from n steps. "
                + "In one step, he can move one, two or three steps. "
                + "Implement a method that calculates the number of possible ways a child can move up the stairs.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
