using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.MaxHeight
{
    public class Solution : ISolution
    {
        private List<Box> boxes;

        public Solution(List<Box> boxes)
        {
            this.boxes = boxes;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            boxes.Sort();

            double maxHeight = 0;
            var memo = new double[boxes.Count];

            for (int i = 0; i < boxes.Count; i++)
            {
                var height = FindMaxHeight(i, memo);

                if (height > maxHeight)
                {
                    maxHeight = height;
                }
            }

            Console.WriteLine($"Max height {maxHeight}");
        }

        private double FindMaxHeight(int boxIndex, double[] memo)
        {
            if (boxIndex >= boxes.Count)
            {
                return 0;
            }

            if (memo[boxIndex] != 0)
            {
                return memo[boxIndex];
            }

            if (boxIndex == boxes.Count - 1)
            {
                memo[boxIndex] = boxes[boxIndex].Height;
                return boxes[boxIndex].Height;
            }

            var box = boxes[boxIndex];
            var maxHeight = box.Height;

            for (int i = boxIndex + 1; i < boxes.Count; i++)
            {
                if (boxes[i].CanBeAbove(box))
                {
                    var height = FindMaxHeight(i, memo) + box.Height;

                    if (height > maxHeight)
                    {
                        maxHeight = height;
                    }
                }
            }

            memo[boxIndex] = maxHeight;
            return maxHeight;
        }
    }
}
