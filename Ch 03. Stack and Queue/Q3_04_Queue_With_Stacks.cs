using Contracts;
using Structures;
using System;

namespace Chapter03
{
    public class Q3_04_Queue_With_Stacks : IQuestion
    {
        public string GetDescription()
        {
            return "Write a MyQueue class that implements a queue using two stacks.";
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
}
