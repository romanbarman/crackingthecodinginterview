using System;

namespace Chapter03.Array3Stack
{
    public class Stack
    {
        private static int[] elements = new int[3];
        private const int StackCount = 3;

        private int number;
        private int lastIndex = -1;

        public Stack(int number)
        {
            this.number = number;
        }

        public int Pop()
        {
            if (lastIndex == -1)
            {
                throw new InvalidOperationException();
            }

            var result = elements[lastIndex];
            lastIndex -= StackCount;

            if (lastIndex < 0)
            {
                lastIndex = -1;
            }

            return result;
        }

        public void Push(int value)
        {
            if (lastIndex == -1)
            {
                lastIndex = number - 1;
                elements[lastIndex] = value;

                return;
            }

            if (lastIndex + StackCount > elements.Length - 1)
            {
                IncreaseArray();
            }

            lastIndex += StackCount;
            elements[lastIndex] = value;
        }

        public int Peek()
        {
            if (lastIndex == -1)
            {
                throw new InvalidOperationException();
            }

            return elements[lastIndex];
        }

        public bool IsEmpty()
        {
            return lastIndex == -1;
        }

        public void Show()
        {
            Console.Write($"Stack {number}: ");
            for (var i = lastIndex; i > -1; i -= StackCount)
            {
                Console.Write($"{elements[i]} ");
            }
            Console.WriteLine();
        }

        private void IncreaseArray()
        {
            var newArray = new int[elements.Length * 2];
            Copy(newArray);
            elements = newArray;
        }

        private void Copy(int[] newArray)
        {
            for (var i = 0; i < elements.Length; i++)
            {
                newArray[i] = elements[i];
            }
        }
    }
}
