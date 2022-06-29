using System;

namespace Structures
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public class Node
        {
            public T Value { get; }
            public Node Left { get; internal set; }
            public Node Right { get; internal set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node root;

        public Node Root { get { return root; } }

        public void Add(T value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;

            while (current != null)
            {
                var compareResult = value.CompareTo(current.Value);

                if (compareResult == -1 || compareResult == 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        return;
                    }
                    else
                    {
                        current = current.Left;
                        continue;
                    }
                }

                if (current.Right == null)
                {
                    current.Right = node;
                    return;
                }
                else
                {
                    current = current.Right;
                    continue;
                }
            }
        }
    }
}
