using Contracts;
using Structures;
using System.Collections.Generic;

namespace Chapter04
{
    public class Q4_01_Has_Route : BaseQuestion
    {

        public override string GetDescription()
        {
            return "Given a directed graph, develop an algorithm that checks for the existence of a route between two nodes.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var node1 = new Graph<int>.Node(1);
            var node2 = new Graph<int>.Node(2);
            var node3 = new Graph<int>.Node(3);
            var node4 = new Graph<int>.Node(4);
            var node5 = new Graph<int>.Node(5);
            var node6 = new Graph<int>.Node(6);
            var node7 = new Graph<int>.Node(7);
            var node8 = new Graph<int>.Node(8);
            var node9 = new Graph<int>.Node(9);
            var node10 = new Graph<int>.Node(10);
            var node11 = new Graph<int>.Node(11);
            var node12 = new Graph<int>.Node(12);

            node1.Add(node2, node3, node4);
            node2.Add(node5);
            node3.Add(node5);
            node4.Add(node7, node8);
            node5.Add(node6, node9);
            node6.Add(node10);
            node7.Add(node11, node12);
            node9.Add(node10);

            var graph = new Graph<int>();
            graph.Add(node1, node2, node3, node4, node5, node6);
            graph.Add(node7, node8, node9, node10, node11, node12);

            var routes = new List<(Graph<int>.Node, Graph<int>.Node)>
            {
                (node1, node12),
                (node2, node6),
                (node4, node10)
            };

            var information = new HasRoute.SolutionInformation(graph, routes);

            var solutions = new ISolution[]
            {
                new HasRoute.Solution1.Solution(information),
                new HasRoute.Solution2.Solution(information)
            };

            return solutions;
        }
    }
}
