using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_05_Sum_Lists : IQuestion
    {
        public string GetDescription()
        {
            return "The two numbers are stored as linked lists, with each node representing one digit. "
                + "All digits are stored in reverse order, with the least significant digit stored at the beginning of the list. "
                + "Write a function that adds two numbers and returns the result as a linked list. "
                + "Additionally, solve the problem, assuming that the numbers are written in direct order.";
        }

        public void Run()
        {
            var sumPairs = new LinkedListNode<int>[][]
            {
                new [] { LinkedListNode<int>.CreateLinkedList(new[] { 7, 1, 6 }), LinkedListNode<int>.CreateLinkedList(new[] { 5, 9, 2 }) },
                new [] { LinkedListNode<int>.CreateLinkedList(new[] { 9, 9, 9 }), LinkedListNode<int>.CreateLinkedList(new[] { 9, 9, 9 }) },
                new [] { LinkedListNode<int>.CreateLinkedList(new[] { 7, 1 }), LinkedListNode<int>.CreateLinkedList(new[] { 5, 9, 2 }) },
                new [] { LinkedListNode<int>.CreateLinkedList(new[] { 7, 1, 6 }), LinkedListNode<int>.CreateLinkedList(new[] { 5, 9 }) }
            };

            foreach (var pair in sumPairs)
            {
                pair[0].Show();
                Console.Write("; ");
                pair[1].Show();
                Console.Write(": Sum1 -> ");
                Sum1(pair[0], pair[1]).Show();
                Console.WriteLine();
            }

            foreach (var pair in sumPairs)
            {
                pair[0].Show();
                Console.Write("; ");
                pair[1].Show();
                Console.Write(": Sum2 -> ");
                Sum2(pair[0], pair[1]).Show();
                Console.WriteLine();
            }
        }

        private LinkedListNode<int> Sum2(LinkedListNode<int> a, LinkedListNode<int> b)
        {
            Reverse(ref a);
            Reverse(ref b);

            var sum = Sum1(a, b);

            Reverse(ref sum);

            return sum;
        }

        private void Reverse(ref LinkedListNode<int> top)
        {
            var newTop = top;

            var current = top.Next;
            newTop.SetNext(null);

            while (current != null)
            {
                var next = current.Next;

                current.SetNext(newTop);
                newTop = current;

                current = next;
            }

            top = newTop;
        }

        private LinkedListNode<int> Sum1(LinkedListNode<int> a, LinkedListNode<int> b)
        {
            var currentA = a;
            var currentB = b;

            var (currentRank, nextRank) = SumToNumbers(a.Value, b.Value);
            var result = new LinkedListNode<int>(currentRank);
            var currentResult = result;

            currentA = a.Next;
            currentB = b.Next;

            while (currentA != null || currentB != null)
            {
                if (currentA != null && currentB != null)
                {
                    (currentRank, nextRank) = SumToNumbers(currentA.Value, currentB.Value + nextRank);
                    currentResult.SetNext(new LinkedListNode<int>(currentRank));

                    currentResult = currentResult.Next;
                    currentA = currentA.Next;
                    currentB = currentB.Next;

                    continue;
                }

                if (currentA == null)
                {
                    (currentRank, nextRank) = SumToNumbers(nextRank, currentB.Value);
                    currentResult.SetNext(new LinkedListNode<int>(currentRank));

                    currentResult = currentResult.Next;
                    currentB = currentB.Next;

                    continue;
                }

                if (currentB == null)
                {
                    (currentRank, nextRank) = SumToNumbers(currentA.Value, nextRank);
                    currentResult.SetNext(new LinkedListNode<int>(currentRank));

                    currentResult = currentResult.Next;
                    currentA = currentA.Next;

                    continue;
                }
            }

            if (nextRank != 0)
            {
                currentResult.SetNext(new LinkedListNode<int>(nextRank));
            }

            return result;
        }

        private (int, int) SumToNumbers(int a, int b)
        {
            var sum = a + b;

            if (sum < 10)
            {
                return (sum, 0);
            }

            return (sum % 10, sum / 10);
        }
    }
}
