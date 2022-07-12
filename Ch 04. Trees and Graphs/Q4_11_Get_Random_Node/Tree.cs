using System;

namespace Chapter04.GetRandomNode
{
    public class Tree
    {
        private TreeNode root = null;

        public int Size
        {
            get { return root?.Size ?? 0; }
        }

        public TreeNode GetRandomNode()
        {
            if (root == null)
            {
                return null;
            }

            var random = new Random();

            return root.GetNode(random.Next(Size));
        }

        public void Add(int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
            }
            else
            {
                root.Add(data);
            }
        }

        public void Show()
        {
            root?.Show();
        }
    }
}
