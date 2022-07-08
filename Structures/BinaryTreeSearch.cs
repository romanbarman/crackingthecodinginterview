using Structures.Interfaces;
using System;

namespace Structures
{
    public class BinaryTreeSearch<T> where T : IComparable<T>
    {
        private IBinaryTreeNode<T> root;

        public IBinaryTreeNode<T> Root { get { return root; } }

        public void Add(T value)
        {
            var node = new BinaryTreeNode<T>(value);

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
                        current.SetLeft(node);
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
                    current.SetRight(node);
                    return;
                }
                else
                {
                    current = current.Right;
                    continue;
                }
            }
        }

        public void Show()
        {
            root.Show();
        }
    }
}
