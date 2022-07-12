using System;

namespace Chapter04.GetRandomNode
{
    public class TreeNode
    {
        public TreeNode Left { get; private set; }
        public TreeNode Right { get; private set; }
        public int Size { get; private set; }
        public int Data { get; }

        public TreeNode(int data)
        {
            Data = data;
            Size = 1;
        }

        public TreeNode GetNode(int i)
        {
            var leftSize = Left == null ? 0 : Left.Size;

            if (i < leftSize)
            {
                return Left.GetNode(i);
            }

            if (i == leftSize)
            {
                return this;
            }

            return Right.GetNode(i - (leftSize + 1));
        }

        public void Add(int data)
        {
            if (data <= Data)
            {
                if (Left == null)
                {
                    Left = new TreeNode(data);
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode(data);
                }
                else
                {
                    Right.Add(data);
                }
            }

            Size++;
        }

        public TreeNode Find(int data)
        {
            if (data == Data)
            {
                return this;
            }

            if (data <= Data)
            {
                return Left?.Find(data);
            }
            else
            {
                return Right?.Find(data);
            }
        }

        public void Show()
        {
            Show(this);
        }

        private void Show(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left == null && node.Right == null)
            {
                return;
            }

            Console.Write($"{node.Data}");

            if (node.Left != null)
            {
                Console.Write($" Left -> {node.Left.Data}");
            }

            if (node.Right != null)
            {
                Console.Write($" Right -> {node.Right.Data}");
            }

            Console.WriteLine();

            Show(node.Left);
            Show(node.Right);
        }
    }
}
