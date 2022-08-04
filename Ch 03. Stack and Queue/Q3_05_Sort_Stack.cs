using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_05_Sort_Stack : BaseQuestion
    {
        public override string GetDescription()
        {
            return "Write a program to sort a stack so that the smallest element is at the top of the stack. "
                + "You can use an additional temporary stack.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return new ISolution[] { new SortStack.Solution(Create()) };
        }

        private static Structures.Stack<int> Create()
        {
            var stack = new Structures.Stack<int>();
            stack.Push(9);
            stack.Push(1);
            stack.Push(8);
            stack.Push(7);
            stack.Push(2);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);

            return stack;
        }
    }
}
