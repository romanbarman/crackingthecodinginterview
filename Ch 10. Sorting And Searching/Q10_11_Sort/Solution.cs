using Contracts;
using System;

namespace Chapter10.Sort
{
    public class Solution : ISolution
    {
        private int[] array;

        public Solution(int[] array)
        {
            this.array = array;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");

            Sort();

            Console.WriteLine($"Result: {string.Join(", ", array)}");
        }

        private void Sort()
        {
            for (var i = 1; i < array.Length; i += 2)
            {
                var biggwstIndex = MaxIndex(i - 1, i, i + 1);

                if (i != biggwstIndex)
                    Swap(i, biggwstIndex);
            }
        }

        private int MaxIndex(int a, int b, int c)
        {
            var aValue = a >= 0 && a < array.Length ? array[a] : int.MinValue;
            var bValue = b >= 0 && b < array.Length ? array[b] : int.MinValue;
            int cValue = c >= 0 && c < array.Length ? array[c] : int.MinValue;

            var max = Math.Max(aValue, Math.Max(bValue, cValue));

            if (aValue == max)
                return a;

            if (bValue == max)
                return b;

            return c;
        }

        private void Swap(int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
