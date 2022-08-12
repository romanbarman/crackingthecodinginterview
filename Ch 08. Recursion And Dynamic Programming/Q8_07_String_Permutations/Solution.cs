using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.StringPermutations
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
            var list = new List<string>();
            list.Add(str);

            for (int i = 0; i < str.Length - 1; i++)
            {
                var newPermutations = new List<string>();

                foreach (var s in list)
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        newPermutations.Add(Swap(s, i, j));
                    }
                }

                list.AddRange(newPermutations);
            }

            return list;
        }

        private static string Swap(string str, int i, int j)
        {
            var chars = str.ToCharArray();
            var temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;

            return new string(chars);
        }
    }
}
