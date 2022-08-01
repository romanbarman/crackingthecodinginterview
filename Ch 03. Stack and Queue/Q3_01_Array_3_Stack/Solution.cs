using Contracts;
using System;

namespace Chapter03.Array3Stack
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
            var stack1 = new Stack(1);
            var stack2 = new Stack(2);
            var stack3 = new Stack(3);

            {
                stack1.Push(1);
                stack1.Push(2);
                stack1.Push(3);

                stack2.Push(4);
                stack2.Push(5);
                stack2.Push(6);

                stack3.Push(7);
                stack3.Push(8);
                stack3.Push(9);

                stack1.Show();
                stack2.Show();
                stack3.Show();
            }

            {
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");
                Console.WriteLine($"Stack 1: Pop -> {stack1.Pop()}");

                Console.WriteLine($"Stack 2: Pop -> {stack2.Pop()}");
                Console.WriteLine($"Stack 2: Pop -> {stack2.Pop()}");

                Console.WriteLine($"Stack 3: Pop -> {stack3.Pop()}");

                stack1.Show();
                stack2.Show();
                stack3.Show();
            }
        }
    }
}
