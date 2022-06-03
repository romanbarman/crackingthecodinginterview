using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter02
{
    public class Q2_01_Remove_Dups : IQuestion
    {
        public string GetDescription()
        {
            return "Write code to remove duplicates from an unsorted linked list.";
        }

        public void Run()
        {
            var linkedList = CreateLinkedList();
            ShowLinkedList(linkedList);
            Console.Write(": DeleteDublicates -> ");
            DeleteDublicates(linkedList);
            ShowLinkedList(linkedList);
            Console.WriteLine();

            linkedList = CreateLinkedList();
            ShowLinkedList(linkedList);
            Console.Write(": DeleteDublicates2 -> ");
            DeleteDublicates2(linkedList);
            ShowLinkedList(linkedList);
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

        private void ShowLinkedList(Structures.LinkedListNode<int> top)
        {
            var current = top;
            while(current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }
        }

        private Structures.LinkedListNode<int> CreateLinkedList()
        {
            var rand = new Random();
            const int Min = 0;
            const int Max = 5;

            var top = new Structures.LinkedListNode<int>(rand.Next(Min, Max));
            var current = top;

            for (var i = 0; i < 20; i++)
            {
                var newNode = new Structures.LinkedListNode<int>(rand.Next(Min, Max));
                current.SetNext(newNode);
                newNode.SetPrev(current);

                current = newNode;
            }

            return top;
        }
    }
}
