using Structures.Interfaces;
using System.Text;

namespace Chapter04.IsSubtree.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(IBinaryTreeNode<int> t1, IBinaryTreeNode<int> t2) : base(t1, t2) { }

        public override string GetComment()
        {
            return "Simplified solution.";
        }

        protected override bool HasSubTree()
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            GetOrderString(T1, sb1);
            GetOrderString(T2, sb2);

            return sb1.ToString().IndexOf(sb2.ToString()) != -1;
        }

        private void GetOrderString(IBinaryTreeNode<int> node, StringBuilder sb)
        {
            if (node == null)
            {
                sb.Append("X");
                return;
            }

            sb.Append(node.Value + " ");
            GetOrderString(node.Left, sb);
            GetOrderString(node.Right, sb);
        }
    }
}
