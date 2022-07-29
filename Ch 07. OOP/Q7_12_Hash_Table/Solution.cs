using Contracts;
using System;

namespace Chapter07.HashTable
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
            var table = Create();

            Show(table);

            Console.WriteLine();
            Console.WriteLine($"Get by key 'five' -> {table["five"]}");

            Console.WriteLine();
            Console.WriteLine($"Collection after delete key 'seven'");

            table.Remove("seven");

            Show(table);
        }

        public static CustomHashTable<string, int> Create()
        {
            var table = new CustomHashTable<string, int>(5);
            table.Add("one", 1);
            table.Add("three", 3);
            table.Add("five", 5);
            table.Add("seven", 7);
            table.Add("nine", 9);
            table.Add("two", 2);

            return table;
        }

        public static void Show(CustomHashTable<string, int> table)
        {
            foreach (var item in table)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
