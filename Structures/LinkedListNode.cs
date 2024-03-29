﻿using System;

namespace Structures
{
    public class LinkedListNode<T>
    {
        private T value;
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

        public void SetValue(T value)
        {
            this.value = value;
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

        public static LinkedListNode<T> CreateLinkedList(T[] array)
        {
            var top = new LinkedListNode<T>(array[0]);
            var current = top;

            for (var i = 1; i < array.Length; i++)
            {
                var newNode = new LinkedListNode<T>(array[i]);
                current.SetNext(newNode);
                newNode.SetPrev(current);

                current = newNode;
            }

            return top;
        }
    }
}
