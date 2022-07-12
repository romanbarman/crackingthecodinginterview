using Contracts;
using Structures;
using System;

namespace Chapter02.Partition
{
    public class Solution : ISolution
    {
        private LinkedListNode<int> linkedList;

        public Solution(LinkedListNode<int> linkedList)
        {
            this.linkedList = linkedList;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            linkedList.Show();
            var value = 5;
            Console.Write($": Partition {value} -> ");
            Partition(ref linkedList, value);
            linkedList.Show();
        }

        private void Partition(ref LinkedListNode<int> top, int value)
        {
            LinkedListNode<int> beforeMore;

            if (!GetBeforeLessElement(top, value, out beforeMore))
            {
                return;
            }

            LinkedListNode<int> currentSmall = null;

            var current = top;
            if (beforeMore == null)
            {
                currentSmall = top;
                current = top.Next;
            }
            else
            {
                currentSmall = beforeMore.Next;
                beforeMore.SetNext(beforeMore.Next.Next);
            }

            currentSmall.SetNext(null);
            var newTop = currentSmall;


            while (current != null)
            {
                var next = current.Next;
                current.SetNext(currentSmall.Next);
                currentSmall.SetNext(current);

                if (current.Value < value)
                {
                    currentSmall = currentSmall.Next;
                }

                current = next;
            }

            top = newTop;
        }

        private bool GetBeforeLessElement(LinkedListNode<int> top, int value, out LinkedListNode<int> node)
        {
            var current = top;

            if (current.Value < value)
            {
                node = null;
                return true;
            }

            while (current.Next != null)
            {

                if (current.Next.Value < value)
                {
                    node = current;
                    return true;
                }

                current = current.Next;
            }

            node = null;
            return false; ;
        }
    }
}
