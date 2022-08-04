using Contracts;
using System;

namespace Chapter03.MinValue
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
            var stack = new Stack();
            stack.Push(6);
            stack.Push(4);
            stack.Push(7);
            stack.Push(1);

            stack.Show();
            Console.Write($": Min -> {stack.Min()}");
            Console.WriteLine();

            stack.Pop();
            stack.Show();
            Console.Write($": Min -> {stack.Min()}");
            Console.WriteLine();
        }
    }
}
