using Contracts;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_07_Intersection : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Check if two given singly linked lists intersect. Return the intersection node.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new Intersection.Solution(new[] { CreateWithIntersection(), CreateWithoutIntersection() }) };
        }

        private static (Structures.LinkedListNode<int>, Structures.LinkedListNode<int>) CreateWithIntersection()
        {
            var list1 = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4 });
            var list2 = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 5, 6 });
            var list3 = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 7, 8, 9 });

            list1.Next.Next.Next.SetNext(list3);
            list2.Next.SetNext(list3);

            return (list1, list2);
        }

        private static (Structures.LinkedListNode<int>, Structures.LinkedListNode<int>) CreateWithoutIntersection()
        {
            var list1 = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4 });
            var list2 = Structures.LinkedListNode<int>.CreateLinkedList(new[] { 5, 6 });

            return (list1, list2);
        }
    }
}
