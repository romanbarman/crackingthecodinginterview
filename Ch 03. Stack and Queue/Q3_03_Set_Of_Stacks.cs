using Contracts;
using System;

namespace Chapter03
{
    public class Q3_03_Set_Of_Stacks : IQuestion
    {
        public string GetDescription()
        {
            return "Implement the SetOfStack data structure. Implement the function popAt(int index).";
        }

        public void Run()
        {
            FirstCase();
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

        public class Stack<T>
        {
            public class Node
            {
                public Node(T value)
                {
                    Value = value;
                }

                public T Value { get; }
                public Node Next { get; set; }
            }

            private Node top;
            public int Length { get; private set; } = 0;

            public T Pop()
            {
                if (top == null)
                {
                    throw new InvalidOperationException();
                }

                var result = top.Value;
                top = top.Next;
                Length--;

                return result;
            }

            public void Push(T value)
            {
                var node = new Node(value);
                node.Next = top;
                top = node;
                Length++;
            }

            public T Peek()
            {
                if (top == null)
                {
                    throw new InvalidOperationException();
                }

                return top.Value;
            }

            public T Peek(int index)
            {
                if (top == null)
                {
                    throw new IndexOutOfRangeException();
                }

                var i = 0;
                var current = top;

                while (current != null && i <= index)
                {
                    if (i == index)
                    {
                        return current.Value;
                    }

                    i++;
                    current = current.Next;
                }

                throw new IndexOutOfRangeException();
            }

            public T Pop(int index)
            {
                if (top == null)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == 0)
                {
                    var result = top.Value;
                    top = top.Next;
                    Length--;

                    return result;
                }

                var i = 1;
                var current = top;

                while (current.Next != null && i <= index)
                {
                    if (i == index)
                    {
                        var result = current.Next.Value;
                        current.Next = current.Next.Next;
                        Length--;

                        return result;
                    }

                    i++;
                    current = current.Next;
                }

                throw new IndexOutOfRangeException();
            }

            public bool IsEmpty()
            {
                return top == null;
            }

            public Node GetTop()
            {
                return top;
            }
        }

        public class SetOfStacks
        {
            private Stack<Stack<int>> setOfStacks = new Stack<Stack<int>>();
            private const int StackSize = 3;
            private int currentStackSize = 0;

            public bool IsEmpty()
            {
                return setOfStacks.IsEmpty();
            }

            public void Push(int value)
            {
                if (setOfStacks.IsEmpty())
                {
                    setOfStacks.Push(new Stack<int>());
                }

                if (currentStackSize >= StackSize)
                {
                    setOfStacks.Push(new Stack<int>());
                    currentStackSize = 0;
                }

                setOfStacks.Peek().Push(value);
                currentStackSize++; 
            }

            public int Pop(int index)
            {
                if (IsEmpty())
                {
                    throw new IndexOutOfRangeException();
                }

                var (stackIndex, indexInStack) = GetIndexes(index);

                var result = setOfStacks.Peek(stackIndex).Pop(indexInStack);

                BalanceStacks(stackIndex);

                return result;
            }

            public int Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException();
                }

                return setOfStacks.Peek().Peek();
            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException();
                }

                var result = setOfStacks.Peek().Pop();
                currentStackSize--;

                if (currentStackSize == 0)
                {
                    PopLastStack();
                }

                return result;
            }

            public void Show()
            {
                var currentStack = setOfStacks.GetTop();
                var i = 1;

                while (currentStack != null)
                {
                    Console.Write($"Stack {i}: ");
                    var currentNode = currentStack.Value?.GetTop();

                    while (currentNode != null)
                    {
                        Console.Write($"{currentNode.Value} ");
                        currentNode = currentNode.Next;
                    }

                    Console.WriteLine();
                    currentStack = currentStack.Next;
                    i++;
                }
            }

            private void BalanceStacks(int stackIndex)
            {
                if (stackIndex == 0)
                {
                    DeleteLastStakIfNeed();
                    return;
                }

                for (var i = stackIndex; i > 0; i--)
                {
                    var reverseStack = GetReverseStack(setOfStacks.Peek(i - 1));
                    setOfStacks.Peek(i).Push(reverseStack.Pop());
                    MoveElements(setOfStacks.Peek(i - 1), reverseStack);
                }

                DeleteLastStakIfNeed();
            }

            private (int, int) GetIndexes(int index)
            {
                var sumOfLength = 0;
                for (int i = 0; i < setOfStacks.Length; i++)
                {
                    var stackLength = setOfStacks.Peek(i).Length;
                    if (sumOfLength + stackLength > index)
                    {
                        return (i, index - sumOfLength);
                    }

                    sumOfLength += stackLength;
                }

                throw new IndexOutOfRangeException();
            }

            private void DeleteLastStakIfNeed()
            {
                if (setOfStacks.Peek().IsEmpty())
                {
                    PopLastStack();
                }
            }

            private void MoveElements(Stack<int> original, Stack<int> reverse)
            {
                while (!reverse.IsEmpty())
                {
                    original.Push(reverse.Pop());
                }
            }

            private Stack<int> GetReverseStack(Stack<int> stack)
            {
                var result = new Stack<int>();

                while (!stack.IsEmpty())
                {
                    result.Push(stack.Pop());
                }

                return result;
            }

            private void PopLastStack()
            {
                currentStackSize = StackSize;
                setOfStacks.Pop();
            }
        }
    }
}
