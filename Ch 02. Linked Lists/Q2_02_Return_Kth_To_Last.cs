using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_02_Return_Kth_To_Last : BaseQuestion
    {
        private static readonly ISolution[] solutins = new ISolution[]
        {
            new ReturnKthToLast.Solution(Structures.LinkedListNode<int>.CreateLinkedList(0, 20, 20), 19)
        };

        public override string GetDescription()
        {
            return "Implement an algorithm to find the kth element from the end in a singly linked list.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutins;
        }
    }
}
