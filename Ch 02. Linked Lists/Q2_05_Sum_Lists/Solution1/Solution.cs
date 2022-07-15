using Structures;

namespace Chapter02.SumLists.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(LinkedListNode<int>[][] sumPairs) : base(sumPairs) { }

        public override string GetComment()
        {
            return "Solution when the numbers are written in reverse order.";
        }

        protected override LinkedListNode<int> Sum(LinkedListNode<int> a, LinkedListNode<int> b)
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
