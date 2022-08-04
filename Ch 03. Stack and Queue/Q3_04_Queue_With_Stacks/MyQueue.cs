using Structures;
using System;

namespace Chapter03.QueueWithStacks
{
    public class MyQueue
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> queue = new Stack<int>();
        private bool isAdd = false;
        private bool isRemove = false;

        public void Add(int value)
        {
            if (isRemove)
            {
                Move(stack, queue);
                isRemove = false;
            }

            stack.Push(value);
            isAdd = true;
        }

        public int Remove()
        {
            if (isAdd)
            {
                Move(queue, stack);
                isAdd = false;
            }

            if (queue.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            isRemove = true;
            return queue.Pop();
        }

        public bool IsEmpty()
        {
            return stack.IsEmpty() && queue.IsEmpty();
        }

        public int Peek()
        {
            if (isAdd)
            {
                Move(queue, stack);
                isAdd = false;
            }

            if (queue.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            isRemove = true;
            return queue.Peek();
        }

        private void Move(Stack<int> destination, Stack<int> source)
        {
            while (!source.IsEmpty())
            {
                destination.Push(source.Pop());
            }
        }
    }
}
