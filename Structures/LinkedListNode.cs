using System;

namespace Structures
{
    public class LinkedListNode<T>
    {
        private readonly T value;
        private LinkedListNode<T> next;
        private LinkedListNode<T> prev;

        public LinkedListNode(T value)
        {
            this.value = value;
        }

        public LinkedListNode<T> Next { get { return next; } }
        public LinkedListNode<T> Prev { get { return prev; } }
        public T Value { get { return value; } }

        public void SetNext(LinkedListNode<T> next)
        {
            this.next = next;
        }

        public void SetPrev(LinkedListNode<T> prev)
        {
            this.prev = prev;
        }

        public void Show()
        {
            Console.Write($"{Value} ");

            var current = Next;
            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
        }

        public static LinkedListNode<int> CreateLinkedList(int min, int max, int count)
        {
            var rand = new Random();

            var top = new LinkedListNode<int>(rand.Next(min, max));
            var current = top;

            for (var i = 0; i < count - 1; i++)
            {
                var newNode = new LinkedListNode<int>(rand.Next(min, max));
                current.SetNext(newNode);
                newNode.SetPrev(current);

                current = newNode;
            }

            return top;
        }
    }
}
