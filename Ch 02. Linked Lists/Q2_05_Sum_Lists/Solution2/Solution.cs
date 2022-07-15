using Structures;

namespace Chapter02.SumLists.Solution2
{
    public class Solution : Solution1.Solution
    {
        public Solution(LinkedListNode<int>[][] sumPairs) : base(sumPairs) { }

        public override string GetComment()
        {
            return "Solution when the numbers are written in direct order.";
        }

        protected override LinkedListNode<int> Sum(LinkedListNode<int> a, LinkedListNode<int> b)
        {
            Reverse(ref a);
            Reverse(ref b);

            var sum = base.Sum(a, b);

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
    }
}
