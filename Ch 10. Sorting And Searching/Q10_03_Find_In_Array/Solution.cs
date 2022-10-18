using Contracts;
using System;

namespace Chapter10.FindInArray
{
    public class Solution : ISolution
    {
        private int[] array;
        private int element;

        public Solution(int[] array, int element)
        {
            this.array = array;
            this.element = element;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(" ", array)}");
            Console.WriteLine($"Element: {element}");
            Console.WriteLine($"Index: {IndexOf()}");
        }

        private int IndexOf()
        {
            var middleIndex = (array.Length - 1) / 2;
            var lastIndex = array.Length - 1;
            var firstIndex = 0;

            if (array[lastIndex] == element)
            {
                return lastIndex;
            }

            if (array[firstIndex] == element)
            {
                return 0;
            }

            while (middleIndex != firstIndex && middleIndex != lastIndex)
            {
                var currentValue = array[middleIndex];

                if (currentValue == element)
                {
                    return middleIndex;
                }

                if (currentValue < array[lastIndex])
                {
                    if (element > currentValue && element < array[lastIndex])
                    {
                        firstIndex = middleIndex;
                        middleIndex += (lastIndex - middleIndex) / 2;
                    }
                    else
                    {
                        lastIndex = middleIndex;
                        middleIndex -= (middleIndex - firstIndex) / 2;
                    }
                }
                else
                {
                    if (element > array[firstIndex] && element < currentValue)
                    {
                        lastIndex = middleIndex;
                        middleIndex -= (middleIndex - firstIndex) / 2;
                    }
                    else
                    {
                        firstIndex = middleIndex;
                        middleIndex += (lastIndex - middleIndex) / 2;
                    }
                }
            }

            return -1;
        }
    }
}
