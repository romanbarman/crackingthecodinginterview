using Structures;

namespace Chapter04.HasRoute.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(SolutionInformation information) : base(information) { }

        public override string GetComment()
        {
            return "Breadth-First Search.";
        }

        protected override bool HasRoute(Graph<int>.Node nodeA, Graph<int>.Node nodeB)
        {
            var queue = new Queue<Graph<int>.Node>();
            nodeA.IsVisited = true;
            queue.Add(nodeA);

            while (!queue.IsEmpty())
            {
                var node = queue.Remove();

                if (node == nodeB)
                {
                    return true;
                }

                foreach (var child in node.Children)
                {
                    if (!child.IsVisited)
                    {
                        child.IsVisited = true;
                        queue.Add(child);
                    }
                }
            }

            return false;
        }
    }
}
