using Contracts;
using Structures;
using System;

namespace Chapter02.Intersection
{
    public class Solution : ISolution
    {
        private (LinkedListNode<int> list1, LinkedListNode<int> list2)[] listsPairs;

        public Solution((LinkedListNode<int>, LinkedListNode<int>)[] listsPairs)
        {
            this.listsPairs = listsPairs;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var pair in listsPairs)
            {
                Show(pair.list1, pair.list2);
            }
        }

        private static void Show(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            list1.Show();
            Console.Write("; ");
            list2.Show();
            Console.WriteLine($": GetIntersectNode -> {GetIntersectNode(list1, list2)?.Value.ToString() ?? "NO"}");
            Console.WriteLine();
        }

        private static LinkedListNode<int> GetIntersectNode(LinkedListNode<int> list1, LinkedListNode<int> list2)
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

        private static LinkedListNode<int> Move(LinkedListNode<int> node, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                node = node.Next;
            }

            return node;
        }


        private static LinkedListNode<int> GetIntersect(LinkedListNode<int> node1, LinkedListNode<int> node2)
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

        private static int GetLength(LinkedListNode<int> top)
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

        private static bool HasIntersection(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            return GetLastElement(list1) == GetLastElement(list2);
        }

        private static LinkedListNode<int> GetLastElement(LinkedListNode<int> top)
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
