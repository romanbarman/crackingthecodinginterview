using Contracts;
using Structures;
using System;

namespace Chapter02.LoopDetection
{
    public class Solution : ISolution
    {
        private readonly (LinkedListNode<int> list, int length)[] listsInfo;

        public Solution((LinkedListNode<int>, int)[] listsInfo) => this.listsInfo = listsInfo;

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            foreach (var info in listsInfo)
            {
                ShowList(info.list, info.length);
                Console.WriteLine($": GetLoopBegin -> {GetLoopBegin(info.list)?.Value.ToString() ?? "NO"}");
                Console.WriteLine();
            }
        }

        private static LinkedListNode<int> GetLoopBegin(LinkedListNode<int> top)
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

        private static bool IsLoop(LinkedListNode<int> top)
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

        private static void ShowList(LinkedListNode<int> top, int nodesCount)
        {
            var current = top;

            for (int i = 0; i < nodesCount; i++)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
        }
    }
}
