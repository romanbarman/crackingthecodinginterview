using Contracts;
using System;

namespace Chapter03.SetOfStacks
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
            FirstCase();

            Console.WriteLine();

            SecondCase();
        }

        private void SecondCase()
        {
            Console.WriteLine("Second case");
            var setOfStack = new SetOfStacks();
            setOfStack.Push(1);
            setOfStack.Push(2);
            setOfStack.Push(3);

            setOfStack.Push(4);
            setOfStack.Push(5);
            setOfStack.Push(6);

            setOfStack.Push(7);
            setOfStack.Push(8);

            setOfStack.Show();

            var index = 6;
            Console.WriteLine($"Result after pop at index {index}");

            setOfStack.Pop(index);

            setOfStack.Show();
        }

        private void FirstCase()
        {
            Console.WriteLine("Fisrt case");
            var setOfStack = new SetOfStacks();
            setOfStack.Push(1);
            setOfStack.Push(2);
            setOfStack.Push(3);

            setOfStack.Push(4);
            setOfStack.Push(5);
            setOfStack.Push(6);

            setOfStack.Push(7);
            setOfStack.Push(8);

            setOfStack.Show();
            Console.WriteLine("Result after pop");

            setOfStack.Pop();
            setOfStack.Pop();
            setOfStack.Pop();

            setOfStack.Show();
        }
    }
}
