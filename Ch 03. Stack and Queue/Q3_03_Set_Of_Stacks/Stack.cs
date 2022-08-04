using System;

namespace Chapter03.SetOfStacks
{
    public class Stack<T>
    {
        public class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; }
            public Node Next { get; set; }
        }

        private Node top;
        public int Length { get; private set; } = 0;

        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            var result = top.Value;
            top = top.Next;
            Length--;

            return result;
        }

        public void Push(T value)
        {
            var node = new Node(value);
            node.Next = top;
            top = node;
            Length++;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            return top.Value;
        }

        public T Peek(int index)
        {
            if (top == null)
            {
                throw new IndexOutOfRangeException();
            }

            var i = 0;
            var current = top;

            while (current != null && i <= index)
            {
                if (i == index)
                {
                    return current.Value;
                }

                i++;
                current = current.Next;
            }

            throw new IndexOutOfRangeException();
        }

        public T Pop(int index)
        {
            if (top == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                var result = top.Value;
                top = top.Next;
                Length--;

                return result;
            }

            var i = 1;
            var current = top;

            while (current.Next != null && i <= index)
            {
                if (i == index)
                {
                    var result = current.Next.Value;
                    current.Next = current.Next.Next;
                    Length--;

                    return result;
                }

                i++;
                current = current.Next;
            }

            throw new IndexOutOfRangeException();
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public Node GetTop()
        {
            return top;
        }
    }
}
