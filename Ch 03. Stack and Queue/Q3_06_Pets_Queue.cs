using Contracts;
using System.Collections.Generic;

namespace Chapter03
{
    public class Q3_06_Pets_Queue : BaseQuestion
    {
        private static readonly ISolution[] solutions = new ISolution[]
        {
            new PetsQueue.Solution()
        };

        public override string GetDescription()
        {
            return "The animal shelter only has dogs and cats, and work is done on a first-come, first-served basis. "
                + "People have to pick up the \"oldest\" every time, but they can choose a cat or a dog. "
                + "You can not choose any animal you like. "
                + "Create a data structure that provides the functionality of this system and implements the enqueue, dequeueAny, dequeueDog, dequeueCat operations. "
                + "The built-in LinkedList data structure is allowed.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
