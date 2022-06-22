using System;
using System.Collections.Generic;
using System.Linq;

namespace Structures
{
    public class Graph<T>
    {
        public class Node
        {
            public T Value { get; }
            public IList<Node> Children { get; }
            public bool IsVisited { get; set; }

            public Node(T value)
            {
                Value = value;
                Children = new List<Node>();
                IsVisited = false;
            }

            public void Add(params Node[] nodes)
            {
                foreach (var node in nodes)
                {
                    Children.Add(node);
                }
            }
        }

        private IList<Node> nodes = new List<Node>();

        public void Add(params Node[] nodes)
        {
            foreach (var node in nodes)
            {
                this.nodes.Add(node);
            }
        }

        public void ResetVisited()
        {
            foreach (var node in nodes)
            {
                node.IsVisited = false;
            }
        }

        public void Show()
        {
            foreach (var node in nodes)
            {
                Console.WriteLine($"{node.Value} -> {string.Join(", ", node.Children.Select(n => n.Value))}");
            }
        }
    }
}
