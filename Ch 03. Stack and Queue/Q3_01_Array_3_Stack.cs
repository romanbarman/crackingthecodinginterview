using Contracts;
using System;

namespace Chapter03
{
    public class Q3_01_Array_3_Stack : IQuestion
    {
        public string GetDescription()
        {
            return "Describe how you would use a single one-dimensional array to implement three stacks.";
        }

        public void Run()
        {
            var stack1 = new Stack(1);
            var stack2 = new Stack(2);
            var stack3 = new Stack(3);

            {
                stack1.Push(1);
                stack1.Push(2);
                stack1.Push(3);

                stack2.Push(4);
                stack2.Push(5);
                stack2.Push(6);

                stack3.Push(7);
                stack3.Push(8);
                stack3.Push(9);

                stack1.Show();
                stack2.Show();
                stack3.Show();
            }

            {
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");

                Console.WriteLine($"Stack 2: Pop -> {stack2.Pop()}");
                Console.WriteLine($"Stack 2: Pop -> {stack2.Pop()}");

                Console.WriteLine($"Stack 3: Pop -> {stack3.Pop()}");

                stack1.Show();
                stack2.Show();
                stack3.Show();
            }
            
        }

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
}
