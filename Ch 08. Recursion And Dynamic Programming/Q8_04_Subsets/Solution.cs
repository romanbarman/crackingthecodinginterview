using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.Subsets
{
    public class Solution : ISolution
    {
        private readonly List<int> set;

        public Solution(List<int> set)
        {
            this.set = set;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Set: {{{string.Join(", ", set)}}}");
            Console.WriteLine("All subsets:");

            foreach (var subset in GetSubsets(0))
            {
                Console.WriteLine(string.Join(", ", subset));
            }
        }

        private List<List<int>> GetSubsets(int index)
        {
            List<List<int>> allSubsets;

            if (set.Count == index)
            {
                allSubsets = new List<List<int>>();
                allSubsets.Add(new List<int>());

                return allSubsets;
            }

            allSubsets = GetSubsets(index + 1);
            var item = set[index];
            var moreSubsets = new List<List<int>>();

            foreach (var subset in allSubsets)
            {
                var newSubset = new List<int>(subset);
                newSubset.Add(item);

                moreSubsets.Add(newSubset);
            }

            allSubsets.AddRange(moreSubsets);

            return allSubsets;
        }
    }
}
