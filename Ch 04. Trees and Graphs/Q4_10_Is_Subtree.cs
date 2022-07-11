using Contracts;
using Structures;
using Structures.Interfaces;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_10_Is_Subtree : BaseQuestion
    {
        public override string GetDescription()
        {
            return "T1 and T2 are two very large binary trees, with T1 being much larger than T2. "
                + "Write an algorithm to check if T2 is a subtree of T1.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var (t1, t2) = CreateTree();
            return new ISolution[] {
                new IsSubtree.Solution1.Solution(t1, t2),
                new IsSubtree.Solution2.Solution(t1, t2)
            };
        }

        private (IBinaryTreeNode<int>, IBinaryTreeNode<int>) CreateTree()
        {
            var t2 = new BinaryTreeNode<int>(101);

            t2.SetLeft(new BinaryTreeNode<int>(102));
            t2.SetRight(new BinaryTreeNode<int>(103));

            t2.Left.SetLeft(new BinaryTreeNode<int>(104));
            t2.Left.SetRight(new BinaryTreeNode<int>(105));

            t2.Right.SetLeft(new BinaryTreeNode<int>(106));
            t2.Right.SetRight(new BinaryTreeNode<int>(107));

            var t1 = new BinaryTreeNode<int>(1);

            t1.SetLeft(new BinaryTreeNode<int>(2));
            t1.SetRight(new BinaryTreeNode<int>(3));

            t1.Left.SetLeft(new BinaryTreeNode<int>(4));
            t1.Left.SetRight(new BinaryTreeNode<int>(5));

            t1.Right.SetLeft(new BinaryTreeNode<int>(6));
            t1.Right.SetRight(new BinaryTreeNode<int>(7));

            t1.Left.Left.SetLeft(new BinaryTreeNode<int>(8));
            t1.Left.Left.SetRight(new BinaryTreeNode<int>(9));

            t1.Left.Right.SetLeft(new BinaryTreeNode<int>(10));
            t1.Left.Right.SetRight(new BinaryTreeNode<int>(11));

            t1.Right.Left.SetLeft(t2);
            t1.Right.Left.SetRight(new BinaryTreeNode<int>(13));

            t1.Right.Right.SetLeft(new BinaryTreeNode<int>(14));
            t1.Right.Right.SetRight(new BinaryTreeNode<int>(15));

            return (t1, t2);
        }
    }
}
