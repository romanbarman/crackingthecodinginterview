using Contracts;
using Structures;
using System;

namespace Chapter02.ReturnKthToLast
{
    public class Solution : ISolution
    {
        private readonly LinkedListNode<int> top;
        private readonly int k;

        public Solution(LinkedListNode<int> top, int k)
        {
            this.top = top;
            this.k = k;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            top.Show();
            Console.Write($": FindKToLast {k} -> {FindKToLast().Value}");
            Console.WriteLine();
        }

        private LinkedListNode<int> FindKToLast()
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
