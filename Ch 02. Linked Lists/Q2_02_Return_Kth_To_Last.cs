using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_02_Return_Kth_To_Last : IQuestion
    {
        public string GetDescription()
        {
            return "Implement an algorithm to find the kth element from the end in a singly linked list.";
        }

        public void Run()
        {
            var linkedList = LinkedListNode<int>.CreateLinkedList(0, 20, 20);
            var k = 19;
            var node = FindKToLast(linkedList, k);

            linkedList.Show();
            Console.Write($": FindKToLast {k} -> {node.Value}");
            Console.WriteLine();
        }

        private LinkedListNode<int> FindKToLast(LinkedListNode<int> top, int k)
        {
            var first = top;
            var second = top;

            for (var i = 0; i < k; i++)
            {
                if (second == null)
                {
                    return null;
                }

                second = second.Next;
            }

            while (second != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return first;
        }
    }
}
