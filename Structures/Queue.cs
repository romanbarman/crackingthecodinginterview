using System;

namespace Structures
{
    public class Queue<T>
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

        private Node first;
        private Node last;

        public void Add(T value)
        {
            var node = new Node(value);

            if (last != null)
            {
                last.Next = node;
            }

            last = node;

            if (first == null)
            {
                first = last;
            }
        }

        public T Remove()
        {
            if (first == null)
            {
                throw new InvalidOperationException();
            }

            var result = first.Value;
            first = first.Next;
            if (first == null)
            {
                last = null;
            }

            return result;
        }

        public T Peek()
        {
            if (first == null)
            {
                throw new InvalidOperationException();
            }
            return first.Value;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}
