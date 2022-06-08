using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_04_Partition : IQuestion
    {
        public string GetDescription()
        {
            return "Write code to split a linked list around x so that all nodes less than x precede nodes greater than or equal to x. "
                + "If x is contained in a list, then the values of x must follow strictly after elements less than x. "
                + "Breakdown element x can be anywhere in the right part; it does not have to be located between the left and right parts.";
        }

        public void Run()
        {
            var linkedList = LinkedListNode<int>.CreateLinkedList(new[] { 3, 5, 8, 5, 10, 2, 1 });
            linkedList.Show();
            var value = 5;
            Console.Write($": Partition {value} -> ");
            Partition(ref linkedList, value);
            linkedList.Show();
            Console.WriteLine();
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
