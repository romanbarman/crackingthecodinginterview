using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_08_Loop_Detection : IQuestion
    {
        public string GetDescription()
        {
            return "For a circular linked list, implement an algorithm that returns the starting node of the loop.";
        }

        public void Run()
        {
            var list1 = LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4, 5, 6 , 7 , 8 , 9 , 10 });
            list1.Next.Next.Next.Next.Next.Next.Next.Next.Next.SetNext(list1.Next.Next);

            ShowLoopList(list1, 11);
            Console.WriteLine($": GetLoopBegin -> {GetLoopBegin(list1)?.Value.ToString() ?? "NO"}");
            Console.WriteLine();

            var list2 = LinkedListNode<int>.CreateLinkedList(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            list2.Show();
            Console.WriteLine($": GetLoopBegin -> {GetLoopBegin(list2)?.Value.ToString() ?? "NO"}");
            Console.WriteLine();
        }

        private void ShowLoopList(LinkedListNode<int> top, int nodesCount)
        {
            var current = top;

            for (int i = 0; i < nodesCount; i++)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
        }

        private LinkedListNode<int> GetLoopBegin(LinkedListNode<int> top)
        {
            if (!IsLoop(top))
            {
                return null;
            }

            var slow = top;
            var fast = top;

            while (true)
            {
                fast = fast.Next.Next;
                slow = slow.Next;

                if (fast == slow)
                {
                    break;
                }
            }

            slow = top;

            while (true)
            {
                if (slow == fast)
                {
                    return slow;
                }

                slow = slow.Next;
                fast = fast.Next;
            }
        }

        private bool IsLoop(LinkedListNode<int> top)
        {
            var slow = top;
            var fast = top;

            while (fast != null)
            {
                if (fast.Next?.Next == null)
                {
                    return false;
                }

                fast = fast.Next.Next;
                slow = slow.Next;

                if (fast == slow)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
