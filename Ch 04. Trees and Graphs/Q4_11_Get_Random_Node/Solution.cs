using Contracts;
using System;

namespace Chapter04.GetRandomNode
{
    public class Solution : ISolution
    {
        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var tree = Create();
            tree.Show();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"GetRandomNode -> {tree.GetRandomNode().Data}");
            }
        }

        private Tree Create()
        {
            var tree = new Tree();
            tree.Add(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(2);
            tree.Add(7);
            tree.Add(12);
            tree.Add(17);
            tree.Add(9);
            tree.Add(19);

            return tree;
        }
    }
}
