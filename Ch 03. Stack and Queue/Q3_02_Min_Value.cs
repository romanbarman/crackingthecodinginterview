using Contracts;
using System;

namespace Chapter03
{
    public class Q3_02_Min_Value : IQuestion
    {
        public string GetDescription()
        {
            return "How to implement a stack, which, in addition to the standard push and pop functions, will support the min function that returns an element?";
        }

        public void Run()
        {
            var stack = new Stack();
            stack.Push(6);
            stack.Push(4);
            stack.Push(7);
            stack.Push(1);

            stack.Show();
            Console.Write($": Min -> {stack.Min()}");
            Console.WriteLine();

            stack.Pop();
            stack.Show();
            Console.Write($": Min -> {stack.Min()}");
            Console.WriteLine();
        }

        public class Stack
        {
            private class Node
            {
                public Node(int value, int min)
                {
                    Value = value;
                    Min = min;
                }

                public int Value { get; }
                public int Min { get; }
                public Node Next { get; set; }
            }

            private Node top;

            public void Show()
            {
                var current = top;

                while (current != null)
                {
                    Console.Write($"{current.Value} ");
                    current = current.Next;
                }
            }

            public int Pop()
            {
                if (top == null)
                {
                    throw new InvalidOperationException();
                }

                var result = top.Value;
                top = top.Next;

                return result;
            }

            public void Push(int value)
            {
                var min = top == null ? value : value < top.Min ? value : top.Min;
                var node = new Node(value, min);
                node.Next = top;
                top = node;
            }

            public int Peek()
            {
                if (top == null)
                {
                    throw new InvalidOperationException();
                }

                return top.Value;
            }

            public bool IsEmpty()
            {
                return top == null;
            }

            public int Min()
            {
                if (top == null)
                {
                    throw new InvalidOperationException();
                }

                return top.Min;
            }
        }
    }
}
