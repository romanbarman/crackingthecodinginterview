using Contracts;
using Structures;
using System;

namespace Chapter02.DeleteMiddleNode
{
    public class Solution : ISolution
    {
        private LinkedListNode<int> list;

        public Solution(LinkedListNode<int> list)
        {
            this.list = list;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            list.Show();

            var node = list.Next.Next.Next;
            Console.Write($": DeleteNode {node.Value} -> ");

            DeleteNode(node);
            list.Show();
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
