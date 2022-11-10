using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter10.SortByAnagram
{
    public class Solution : ISolution
    {
        private string[] array;

        public Solution(string[] array)
        {
            this.array = array;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");
            Sort();
            Console.WriteLine($"Result: {string.Join(", ", array)}");
        }

        private void Sort()
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var item in array)
            {
                var sortedString = SortString(item);

                if (!dictionary.ContainsKey(sortedString))
                {
                    dictionary[sortedString] = new List<string>();
                }

                dictionary[sortedString].Add(item);
            }

            var i = 0;

            foreach (var item in dictionary)
            {
                foreach (var value in item.Value)
                {
                    array[i] = value;
                    i++;
                }
            }
        }

        private string SortString(string value)
        {
            var charArray = value.ToCharArray();
            Array.Sort(charArray);

            return new string(charArray);
        }
    }
}
