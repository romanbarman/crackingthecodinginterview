using Contracts;
using System.Collections.Generic;

namespace Chapter07
{
    public class Q7_12_Hash_Table : BaseQuestion
    {
        public static ISolution[] solutions = new ISolution[]
        {
            new HashTable.Solution()
        };

        public override string GetDescription()
        {
            return "Design and implement a hash table that uses linked lists to handle collisions.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
