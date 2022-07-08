using Structures.Interfaces;
using System;

namespace Structures
{
    public class BinaryTreeNode<T> : IBinaryTreeNode<T>
    {
        private IBinaryTreeNode<T> left;
        private IBinaryTreeNode<T> right;
        private IBinaryTreeNode<T> parent;

        public T Value { get; }
        public IBinaryTreeNode<T> Left => left;
        public IBinaryTreeNode<T> Right => right;
        public IBinaryTreeNode<T> Parent => parent;

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public void Show()
        {
            Show(this);
        }

        private void Show(IBinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left == null && node.Right == null)
            {
                return;
            }

            Console.Write($"{node.Value}");

            if (node.Left != null)
            {
                Console.Write($" Left -> {node.Left.Value}");
            }

            if (node.Right != null)
            {
                Console.Write($" Right -> {node.Right.Value}");
            }

            Console.WriteLine();

            Show(node.Left);
            Show(node.Right);
        }

        public void SetLeft(IBinaryTreeNode<T> left)
        {
            this.left = left;
            left.SetParent(this);
        }

        public void SetRight(IBinaryTreeNode<T> right)
        {
            this.right = right;
            right.SetParent(this);
        }

        public void SetParent(IBinaryTreeNode<T> parent)
        {
            this.parent = parent;
        }
    }
}
