using Contracts;
using Structures;
using System;

namespace Chapter03.SortStack
{
    public class Solution : ISolution
    {
        private readonly Stack<int> stack;

        public Solution(Stack<int> stack)
        {
            this.stack = stack;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            stack.Show();
            Console.Write(": Sort -> ");
            Sort(stack).Show();
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
