using Structures;
using System.Collections.Generic;

namespace Chapter04.HasRoute
{
    public class SolutionInformation
    {
        public Graph<int> Graph { get; }
        public IList<(Graph<int>.Node, Graph<int>.Node)> Routes { get; }

        public SolutionInformation(Graph<int> graph, IList<(Graph<int>.Node, Graph<int>.Node)> routes)
        {
            Graph = graph;
            Routes = routes;
        }
    }
}
