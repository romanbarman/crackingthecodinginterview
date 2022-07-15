using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_05_Sum_Lists : BaseQuestion
    {
        private static Structures.LinkedListNode<int>[][] sumPairs = new Structures.LinkedListNode<int>[][]
        {
            new [] { Structures.LinkedListNode<int>.CreateLinkedList(new[] { 7, 1, 6 }), Structures.LinkedListNode<int>.CreateLinkedList(new[] { 5, 9, 2 }) },
            new [] { Structures.LinkedListNode<int>.CreateLinkedList(new[] { 9, 9, 9 }), Structures.LinkedListNode<int>.CreateLinkedList(new[] { 9, 9, 9 }) },
            new [] { Structures.LinkedListNode<int>.CreateLinkedList(new[] { 7, 1 }), Structures.LinkedListNode<int>.CreateLinkedList(new[] { 5, 9, 2 }) },
            new [] { Structures.LinkedListNode<int>.CreateLinkedList(new[] { 7, 1, 6 }), Structures.LinkedListNode<int>.CreateLinkedList(new[] { 5, 9 }) }
        };

        private static ISolution[] solutions = new ISolution[]
        {
            new SumLists.Solution1.Solution(sumPairs),
            new SumLists.Solution2.Solution(sumPairs)
        };

        public override string GetDescription()
        {
            return "The two numbers are stored as linked lists, with each node representing one digit. "
                + "All digits are stored in reverse order, with the least significant digit stored at the beginning of the list. "
                + "Write a function that adds two numbers and returns the result as a linked list.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
