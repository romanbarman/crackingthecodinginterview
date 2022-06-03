using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_01_Remove_Dups : IQuestion
    {
        private const int Min = 0;
        private const int Max = 5;
        private const int Count = 20;

        public string GetDescription()
        {
            return "Write code to remove duplicates from an unsorted linked list.";
        }

        public void Run()
        {
            var linkedList = Structures.LinkedListNode<int>.CreateLinkedList(Min, Max, Count);
            linkedList.Show();
            Console.Write(": DeleteDublicates -> ");
            DeleteDublicates(linkedList);
            linkedList.Show();
            Console.WriteLine();

            linkedList = Structures.LinkedListNode<int>.CreateLinkedList(Min, Max, Count);
            linkedList.Show();
            Console.Write(": DeleteDublicates2 -> ");
            DeleteDublicates2(linkedList);
            linkedList.Show();
            Console.WriteLine();
        }

        private void DeleteDublicates2(Structures.LinkedListNode<int> top)
        {
            var first = top;
            var second = top;

            while (first != null)
            {
                while (second.Next != null)
                {
                    if (first.Value == second.Next.Value)
                    {
                        second.SetNext(second.Next.Next);
                    }
                    else
                    {
                        second = second.Next;
                    }
                }

                first = first.Next;
                second = first;
            }
        }

        private void DeleteDublicates(Structures.LinkedListNode<int> top)
        {
            var hashSet = new HashSet<int>();
            hashSet.Add(top.Value);
            var current = top;

            while (current.Next != null)
            {
                if (hashSet.Contains(current.Next.Value))
                {
                    current.SetNext(current.Next.Next);
                }
                else
                {
                    hashSet.Add(current.Next.Value);
                    current = current.Next;
                }
            }
        }
    }
}
