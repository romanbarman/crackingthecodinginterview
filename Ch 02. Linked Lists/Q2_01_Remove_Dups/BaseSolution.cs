using Contracts;
using Structures;
using System;

namespace Chapter02.RemoveDups
{
    public abstract class BaseSolution : ISolution
    {
        private LinkedListNode<int> linkedListNode;

        protected BaseSolution(LinkedListNode<int> linkedListNode)
        {
            this.linkedListNode = linkedListNode;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            linkedListNode.Show();
            Console.Write(": DeleteDublicates -> ");
            DeleteDublicates(linkedListNode);
            linkedListNode.Show();
            Console.WriteLine();
        }

        protected abstract void DeleteDublicates(LinkedListNode<int> top);
    }
}
