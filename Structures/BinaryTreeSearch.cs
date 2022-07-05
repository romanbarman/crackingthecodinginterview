using Structures.Interfaces;
using System;

namespace Structures
{
    public class BinaryTreeSearch<T> where T : IComparable<T>
    {
        public class Node : IBinaryTreeNode<T>
        {
            public T Value { get; }
            public Node Left { get; internal set; }
            public Node Right { get; internal set; }

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

            public Node(T value)
            {
                Value = value;
            }

            public void Show()
            {
                Show(this);
            }

            private void Show(Node node)
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

        public void Show()
        {
            root.Show();
        }
    }
}
