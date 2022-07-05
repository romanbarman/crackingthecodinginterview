using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_01_Remove_Dups : BaseQuestion
    {
        private const int Min = 0;
        private const int Max = 5;
        private const int Count = 20;

        public override string GetDescription()
        {
            return "Write code to remove duplicates from an unsorted linked list.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[]
            {
                new RemoveDups.Solution1.Solution(Structures.LinkedListNode<int>.CreateLinkedList(Min, Max, Count)),
                new RemoveDups.Solution2.Solution(Structures.LinkedListNode<int>.CreateLinkedList(Min, Max, Count))
            };
        }
    }
}
