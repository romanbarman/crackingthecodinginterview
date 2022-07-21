using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_08_Loop_Detection : BaseQuestion
    {
        public override string GetDescription()
        {
            return "For a circular linked list, implement an algorithm that returns the starting node of the loop.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new LoopDetection.Solution(new[] { CreateLoopList(), CreateNotLoopList() }) };
        }

        private static (Structures.LinkedListNode<int>, int) CreateNotLoopList()
        {
            return (Structures.LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 10);
        }

        private static (Structures.LinkedListNode<int>, int) CreateLoopList()
        {
            var list = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            list.Next.Next.Next.Next.Next.Next.Next.Next.Next.SetNext(list.Next.Next);

            return (list, 11);
        }
    }
}
