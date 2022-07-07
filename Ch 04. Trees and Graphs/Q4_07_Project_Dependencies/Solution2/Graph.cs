using System.Collections.Generic;

namespace Chapter04.ProjectDependencies.Solution2
{
    public class Graph
    {
        private Dictionary<string, Project> dictionary = new Dictionary<string, Project>();
        public List<Project> Nodes { get; } = new List<Project>();

        public Project GetOrCreateNode(string name)
        {
            CreateNode(name);

            return dictionary[name];
        }

        public void CreateNode(string name)
        {
            if (!dictionary.ContainsKey(name))
            {
                var node = new Project(name);
                Nodes.Add(node);
                dictionary.Add(name, node);
            }
        }

        public void AddEdge(string startName, string endName)
        {
            var start = GetOrCreateNode(startName);
            var end = GetOrCreateNode(endName);
            start.AddNeighbor(end);
        }
    }
}
