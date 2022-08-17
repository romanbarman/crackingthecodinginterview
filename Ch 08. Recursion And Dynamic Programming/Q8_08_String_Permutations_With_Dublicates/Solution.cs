using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter08.StringPermutationsWithDublicates
{
    public class Solution : ISolution
    {
        private string str;

        public Solution(string str)
        {
            this.str = str;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("GetAllPermutations:");

            foreach (var permutation in GetAllPermutations())
            {
                Console.WriteLine(permutation);
            }
        }

        private List<string> GetAllPermutations()
        {
            var result = new List<string>();

            var dictionary = BuildFrqequencyDictionary();
            GetAllPermutations(dictionary, "", str.Length, result);

            return result;
        }

        private void GetAllPermutations(Dictionary<char, int> dict, string prefix, int remaining, List<string> result)
        {
            if (remaining == 0)
            {
                result.Add(prefix);
                return;
            }

            foreach (var ch in dict.Keys.ToList())
            {
                var count = dict[ch];

                if (count > 0)
                {
                    dict[ch] = count - 1;
                    GetAllPermutations(dict, prefix + ch, remaining - 1, result);
                    dict[ch] = count;
                }
            }
        }

        private Dictionary<char, int> BuildFrqequencyDictionary()
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                if (dictionary.ContainsKey(ch))
                {
                    dictionary[ch] += 1; ;
                }
                else
                {
                    dictionary[ch] = 1;
                }
            }

            return dictionary;
        }
    }
}
