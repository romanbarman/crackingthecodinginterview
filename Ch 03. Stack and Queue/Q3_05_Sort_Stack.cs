using Contracts;
using Structures;
using System;

namespace Chapter03
{
    public class Q3_05_Sort_Stack : IQuestion
    {
        public string GetDescription()
        {
            return "Write a program to sort a stack so that the smallest element is at the top of the stack. "
                + "You can use an additional temporary stack.";
        }

        public void Run()
        {
            var stack = new Stack<int>();
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(7);
            stack.Push(2);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);

            stack.Show();
            Console.Write(": Sort -> ");
            Sort(stack).Show();

            Console.WriteLine();
        }

        private Stack<int> Sort(Stack<int> stack)
        {
            var result = new Stack<int>();
            result.Push(stack.Pop());

            while (!stack.IsEmpty())
            {
                var value = stack.Pop();

                while (!result.IsEmpty())
                {
                    if (result.Peek() < value)
                    {
                        stack.Push(result.Pop());
                    }
                    else
                    {
                        break;
                    }
                }

                result.Push(value);
            }

            return result;
        }
    }
}
