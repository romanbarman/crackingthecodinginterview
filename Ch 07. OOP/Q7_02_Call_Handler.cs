using Contracts;
using System.Collections.Generic;

namespace Chapter07
{
    public class Q7_02_Call_Handler : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new CallHandler.Solution()
        };

        public override string GetDescription()
        {
            return "Call center with three levels of employees: operator, manager and director. "
                + "An incoming call is directed to a free operator. If the operator cannot process the call, "
                + "it is automatically addressed to the manager. If the manager is busy, the call is redirected to the director. "
                + "Design classes and data structures for this task.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
