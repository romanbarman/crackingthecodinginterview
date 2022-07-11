using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_03_Delete_Middle_Node : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Implement an algorithm that removes a node from the middle of a singly linked list. Access is granted only to this node.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new DeleteMiddleNode.Solution(Structures.LinkedListNode<int>.CreateLinkedList(0, 10, 10)) };
        }
    }
}
