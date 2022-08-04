using System;

namespace Chapter03.SetOfStacks
{
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
