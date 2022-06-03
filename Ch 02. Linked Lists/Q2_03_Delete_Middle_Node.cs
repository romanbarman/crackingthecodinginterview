using Contracts;
using Structures;
using System;

namespace Chapter02
{
    public class Q2_03_Delete_Middle_Node : IQuestion
    {
        public string GetDescription()
        {
            return "Implement an algorithm that removes a node from the middle of a singly linked list. Access is granted only to this node.";
        }

        public void Run()
        {
            var linkedList = LinkedListNode<int>.CreateLinkedList(0, 10, 10);
            linkedList.Show();
            var node = linkedList.Next.Next.Next;
            Console.Write($": DeleteNode {node.Value} -> ");
            DeleteNode(node);
            linkedList.Show();
            Console.WriteLine();
        }

        private void DeleteNode(LinkedListNode<int> node)
        {
            if (node == null || node.Next == null)
            {
                node = null;
                return;
            }

            node.SetValue(node.Next.Value);
            node.SetNext(node.Next.Next);
        }
    }
}
