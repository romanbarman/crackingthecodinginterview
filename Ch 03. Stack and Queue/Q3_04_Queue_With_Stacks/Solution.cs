using Contracts;
using System;

namespace Chapter03.QueueWithStacks
{
    public class Solution : ISolution
    {
        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var queue = new MyQueue();

            queue.Add(1);
            queue.Add(2);

            Console.Write($"{queue.Peek()} ");

            queue.Add(3);
            queue.Add(4);

            Console.Write($"{queue.Remove()} ");
            Console.Write($"{queue.Remove()} ");

            queue.Add(5);

            Console.Write($"{queue.Remove()} ");
            Console.Write($"{queue.Remove()} ");
            Console.Write($"{queue.Remove()} ");
            Console.WriteLine();
        }
    }
}
