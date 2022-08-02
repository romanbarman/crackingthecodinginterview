using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_02_Min_Value : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new MinValue.Solution()
        };

        public override string GetDescription()
        {
            return "How to implement a stack, which, in addition to the standard push and pop functions, will support the min function that returns an element?";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
