using Structures;

namespace Chapter04.HasRoute.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(SolutionInformation information) : base(information) { }

        public override string GetComment()
        {
            return "Depth-First Search.";
        }

        protected override bool HasRoute(Graph<int>.Node nodeA, Graph<int>.Node nodeB)
        {
            foreach (var node in nodeA.Children)
            {
                if (CheckRoute(node, nodeB))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckRoute(Graph<int>.Node root, Graph<int>.Node destination)
        {
            if (root == null)
            {
                return false;
            }

            if (root == destination)
            {
                return true;
            }

            root.IsVisited = true;

            foreach (var child in root.Children)
            {
                if (!child.IsVisited)
                {
                    if (CheckRoute(child, destination))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
