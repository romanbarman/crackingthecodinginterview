using Contracts;
using Structures;
using System;

namespace Chapter02.SumLists
{
    public abstract class BaseSolution : ISolution
    {
        private readonly LinkedListNode<int>[][] sumPairs;

        protected BaseSolution(LinkedListNode<int>[][] sumPairs)
        {
            this.sumPairs = sumPairs;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            foreach (var pair in sumPairs)
            {
                pair[0].Show();
                Console.Write("; ");
                pair[1].Show();
                Console.Write(": Sum -> ");
                Sum(pair[0], pair[1]).Show();
                Console.WriteLine();
            }
        }

        protected abstract LinkedListNode<int> Sum(LinkedListNode<int> a, LinkedListNode<int> b);
    }
}
