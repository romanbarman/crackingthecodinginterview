using System;

namespace Structures
{
    public class Stack<T>
    {
        private class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; }
            public Node Next { get; set; }
        }

        private Node top;

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            var result = top.Value;
            top = top.Next;

            return result;
        }

        public void Push(T value)
        {
            var node = new Node(value);
            node.Next = top;
            top = node;
        }

        public T Peek()
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

        public void Show()
        {
            var current = top;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
        }
    }
}
