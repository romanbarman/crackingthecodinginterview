using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_04_Queue_With_Stacks : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new QueueWithStacks.Solution()
        };

        public override string GetDescription()
        {
            return "Write a MyQueue class that implements a queue using two stacks.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
