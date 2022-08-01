using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_01_Array_3_Stack : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new Array3Stack.Solution()
        };

        public override string GetDescription()
        {
            return "Describe how you would use a single one-dimensional array to implement three stacks.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
