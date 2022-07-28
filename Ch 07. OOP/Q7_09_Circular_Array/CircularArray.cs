using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter07.CircularArray
{
    class CircularArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int head = 0;

        public CircularArray(int size)
        {
            array = new T[size];
        }

        public void Shift(int steps)
        {
            head = (head + steps) % array.Length;
        }

        public int Length => array.Length;

        public T this[int index]
        {
            get
            {
                if (index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return array[GetArrayIndex(index)];
            }
            set
            {
                if (index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                array[GetArrayIndex(index)] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = head; i < array.Length; i++)
            {
                yield return array[i];
            }

            for (int i = 0; i < head; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private int GetArrayIndex(int index)
        {
            return index + head % array.Length;
        }
    }
}
