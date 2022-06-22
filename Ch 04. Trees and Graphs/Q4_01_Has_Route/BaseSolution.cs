using Contracts;
using Structures;
using System;

namespace Chapter04.HasRoute
{
    public abstract class BaseSolution : ISolution
    {
        private SolutionInformation information;

        protected BaseSolution(SolutionInformation information)
        {
            this.information = information;
        }

        public bool HasComment => true;

        public abstract string GetComment();

        public void Run()
        {
            Console.WriteLine("Graph");
            information.Graph.Show();

            foreach (var route in information.Routes)
            {
                Console.WriteLine($"Route {route.Item1.Value} -> {route.Item2.Value}: HasRote -> {HasRoute(route.Item1, route.Item2)}");
                information.Graph.ResetVisited();
            }
        }

        protected abstract bool HasRoute(Graph<int>.Node nodeA, Graph<int>.Node nodeB);
    }
}
