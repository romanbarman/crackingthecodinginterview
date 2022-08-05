using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter08.TowerOfHanoi
{
    public class HanoiTower : IEnumerable<int>
    {
        private Stack<int> stack = new Stack<int>();

        private string name;

        public HanoiTower(string name)
        {
            this.name = name;
        }

        public int Count => stack.Count;

        public void Push(int item)
        {
            if (CanPush(item))
            {
                stack.Push(item);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool CanPush(int item)
        {
            return stack.Count == 0 || stack.Peek() > item;
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
