using Structures.Interfaces;
using System;

namespace Structures
{
    public class BinaryTreeNode<T> : IBinaryTreeNode<T>
    {
        public T Value { get; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        IBinaryTreeNode<T> IBinaryTreeNode<T>.Left
        {
            get
            {
                return Left;
            }
        }

        IBinaryTreeNode<T> IBinaryTreeNode<T>.Right
        {
            get
            {
                return Right;
            }
        }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public void Show()
        {
            Show(this);
        }

        private void Show(BinaryTreeNode<T> node)
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
    }
}
