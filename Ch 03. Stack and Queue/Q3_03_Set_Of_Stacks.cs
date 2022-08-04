using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_03_Set_Of_Stacks : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new SetOfStacks.Solution()
        };

        public override string GetDescription()
        {
            return "Implement the SetOfStack data structure. Implement the function popAt(int index).";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
