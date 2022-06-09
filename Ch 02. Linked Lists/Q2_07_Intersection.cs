using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_07_Intersection : IQuestion
    {
        public string GetDescription()
        {
            return "Check if two given singly linked lists intersect. Return the intersection node.";
        }

        public void Run()
        {
            var list1 = LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4 });
            var list2 = LinkedListNode<int>.CreateLinkedList(new[] { 5, 6 });
            var list3 = LinkedListNode<int>.CreateLinkedList(new[] { 7, 8, 9 });

            list1.Next.Next.Next.SetNext(list3);
            list2.Next.SetNext(list3);

            Show(list1, list2);

            list1 = LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4 });
            list2 = LinkedListNode<int>.CreateLinkedList(new[] { 5, 6 });

            Show(list1, list2);
        }

        private void Show(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            list1.Show();
            Console.Write("; ");
            list2.Show();
            Console.WriteLine($": GetIntersectNode -> {GetIntersectNode(list1, list2)?.Value.ToString() ?? "NO"}");
            Console.WriteLine();
        }

        private LinkedListNode<int> GetIntersectNode(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            if (!HasIntersection(list1, list2))
            {
                return null;
            }

            var list1Length = GetLength(list1);
            var list2Length = GetLength(list2);

            if (list1Length == list2Length)
            {
                return GetIntersect(list1, list2);
            }

            if (list1Length > list2Length)
            {
                return GetIntersect(Move(list1, list1Length - list2Length), list2);
            }

            return GetIntersect(list1, Move(list2, list1Length - list2Length));
        }

        private LinkedListNode<int> Move(LinkedListNode<int> node, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                node = node.Next;
            }

            return node;
        }


        private LinkedListNode<int> GetIntersect(LinkedListNode<int> node1, LinkedListNode<int> node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1 == node2)
                {
                    return node1;
                }

                node1 = node1.Next;
                node2 = node2.Next;
            }

            return null;
        }

        private int GetLength(LinkedListNode<int> top)
        {
            var current = top;
            int length = 1;

            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            return length;
        }

        private bool HasIntersection(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            return GetLastElement(list1) == GetLastElement(list2);
        }

        private LinkedListNode<int> GetLastElement(LinkedListNode<int> top)
        {
            var current = top;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }
    }
}
