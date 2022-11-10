using Contracts;
using System;
using System.Linq;

namespace Chapter10.FindInArrayWithEmptyEl
{
    public class Solution : ISolution
    {
        private readonly string[] array;
        private readonly string element;

        public Solution(string[] array, string element)
        {
            this.array = array;
            this.element = element;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Array: {string.Join(",", array.Select(x => "'" + x + "'"))}");
            Console.WriteLine($"Element: {element}");
            Console.WriteLine($"Index: {IndexOf()}");
        }

        private int IndexOf()
        {
            return Search(0, array.Length - 1);
        }

        private int Search(int first, int last)
        {
            if (first > last)
            {
                return -1;
            }

            var middle = (last + first) / 2;

            if (string.IsNullOrEmpty(array[middle]))
            {
                var left = middle - 1;
                var right = middle + 1;

                while (true)
                {
                    if (left < first && right > last)
                    {
                        return -1;
                    }
                    else if (right <= last && !string.IsNullOrEmpty(array[right]))
                    {
                        middle = right;
                        break;
                    }
                    else if (left >= first && !string.IsNullOrEmpty(array[left]))
                    {
                        middle = left;
                        break;
                    }

                    right++;
                    left--;
                }
            }

            if (string.Equals(array[middle], element, StringComparison.Ordinal))
            {
                return middle;
            }
            else if (array[middle].CompareTo(element) < 0)
            {
                return Search(middle + 1, last);
            }
            else
            {
                return Search(first, middle - 1);
            }
        }
    }
}
