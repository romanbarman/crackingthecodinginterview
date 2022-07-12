using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_04_Partition : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new Partition.Solution(Structures.LinkedListNode<int>.CreateLinkedList(new[] { 3, 5, 8, 5, 10, 2, 1 }))
        };

        public override string GetDescription()
        {
            return "Write code to split a linked list around x so that all nodes less than x precede nodes greater than or equal to x. "
                + "If x is contained in a list, then the values of x must follow strictly after elements less than x. "
                + "Breakdown element x can be anywhere in the right part; it does not have to be located between the left and right parts.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
