using Contracts;
using System;
using System.Reflection;

namespace Chapter10.FindInListy
{
    public class Solution : ISolution
    {
        private readonly Listy listy;
        private readonly int element;

        public Solution(Listy listy, int element)
        {
            this.listy = listy;
            this.element = element;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.Write("Listy:");
            var index = 0;

            while (listy.ElementAt(index) != -1)
            {
                Console.Write($" {listy.ElementAt(index)}");
                index++;
            }

            Console.WriteLine();
            Console.WriteLine($"Element: {element}");
            Console.WriteLine($"Index: {IndexOf()}");
        }

        private int IndexOf()
        {
            var lowIndex = -1;
            var highIndex = 2;

            while (lowIndex < highIndex)
            {
                var elementFromListy = listy.ElementAt(highIndex);

                if (elementFromListy == element)
                    return highIndex;

                if (elementFromListy == -1)
                {
                    var diff = highIndex - lowIndex;
                    highIndex -= diff > 1 ? diff / 2 : diff;
                    continue;
                }

                if (elementFromListy < element)
                {
                    lowIndex = highIndex;
                    highIndex *= 2;
                }
                else
                {
                    var diff = highIndex - lowIndex;
                    highIndex -= diff > 1 ? diff / 2 : diff;
                }
            }

            return -1;
        }
    }
}
