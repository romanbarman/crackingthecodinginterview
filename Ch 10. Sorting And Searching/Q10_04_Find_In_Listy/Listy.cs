using System;

namespace Chapter10.FindInListy
{
    public class Listy
    {
        private readonly int[] array;

        public Listy(int[] array)
        {
            Array.Sort(array);
            this.array = array;
        }

        public int ElementAt(int index)
        {
            return array.Length > index && index >= 0 ? array[index] : -1;
        }
    }
}
