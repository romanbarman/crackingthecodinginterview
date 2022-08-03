using System;

namespace Chapter08.MagicIndex.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(int[] array) : base(array) { }

        public override string GetComment()
        {
            return "When the array can contain duplicate values.";
        }

        protected override int GetMagicIndex()
        {
            return GetMagicIndex(0, Array.Length - 1);
        }

        private int GetMagicIndex(int start, int end)
        {
            if (end < start)
            {
                return -1;
            }

            var middle = (start + end) / 2;
            var value = Array[middle];

            if (middle == value)
            {
                return middle;
            }

            var leftEnd = Math.Min(middle - 1, value);
            var left = GetMagicIndex(start, leftEnd);

            if (left > 0)
            {
                return left;
            }

            var rightStart = Math.Max(middle + 1, value);
            return GetMagicIndex(rightStart, end);
        }
    }
}
