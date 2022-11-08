using Contracts;
using System;

namespace Chapter10.FindRank
{
    public class Solution : ISolution
    {
        private readonly int[] array;
        private readonly int rank;
        private RankNode tree;

        public Solution(int[] array, int rank)
        {
            this.array = array;
            this.rank = rank;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");

            foreach (var item in array)
                Track(item);

            Console.WriteLine($"Rank {rank} = {GetRankOfNumber(rank)}");
        }

        private void Track(int data)
        {
            if (tree == null)
                tree = new RankNode(data);
            else
                tree.Insert(data);
        } 

        private int GetRankOfNumber(int number)
        {
            return tree.GetRank(number);
        }
    }
}
