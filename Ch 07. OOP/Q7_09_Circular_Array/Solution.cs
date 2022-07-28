using Contracts;
using System;

namespace Chapter07.CircularArray
{
    public class Solution : ISolution
    {
        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var array = new CircularArray<int>(5);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Show(array);

            var shift = 2;
            array.Shift(shift);
            Console.WriteLine($"Array after shift {shift}");
            Show(array);
        }

        private static void Show(CircularArray<int> array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
