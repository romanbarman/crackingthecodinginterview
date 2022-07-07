using System.Collections.Generic;
using System.Linq;

namespace Chapter04.ProjectDependencies.Solution2
{
    public class Solution : BaseSolution
    {
        public Solution(IList<string> projects, IList<(string, string)> dependencies) : base(projects, dependencies) { }

        protected override IList<string> GetProjectOrderBuild()
        {
            var graph = BuildGraph();
            return GetProjectOrderBuild(graph.Nodes);
        }

        private IList<string> GetProjectOrderBuild(List<Project> nodes)
        {
            var order = new List<Project>();
            order.Add(GetNonDependent(nodes));

            int toBeProcessed = 0;

            while (toBeProcessed < nodes.Count - 1)
            {
                var current = order[toBeProcessed];

                if (current == null)
                {
                    return null;
                }

                current.IsBuild = true;
                var children = current.Children;

                foreach (var child in children)
                {
                    child.DecrementDependencies();
                }

                order.Add(GetNonDependent(nodes));
                toBeProcessed++;
            }

            return order.Select(x => x.Name).ToList();
        }

        private Project GetNonDependent(List<Project> nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Dependencies == 0 && !node.IsBuild)
                {
                    return node;
                }
            }

            return null;
        }

        private Graph BuildGraph()
        {
            var graph = new Graph();

            foreach (var project in Projects)
            {
                graph.CreateNode(project);
            }

            foreach (var dependency in Dependencies)
            {
                graph.AddEdge(dependency.Item2, dependency.Item1);
            }

            return graph;
        }
    }
}
