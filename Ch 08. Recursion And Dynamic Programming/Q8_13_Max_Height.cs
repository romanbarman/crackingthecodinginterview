using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_13_Max_Height : BaseQuestion
    {
        private static ISolution[] solutions = new ISolution[]
        {
            new MaxHeight.Solution(new List<MaxHeight.Box>
            {
                new MaxHeight.Box(13, 26, 26),
                new MaxHeight.Box(18, 15, 5),
                new MaxHeight.Box(14, 14, 14),
                new MaxHeight.Box(20, 20, 20),
                new MaxHeight.Box(12, 24, 24),
                new MaxHeight.Box(14, 28, 28),
                new MaxHeight.Box(15, 30, 30),
                new MaxHeight.Box(17, 17, 17),
                new MaxHeight.Box(19, 10, 10)
            })
        };

        public override string GetDescription()
        {
            return "There is a stack of n boxes of width w, height h and depth d. "
                + "Boxes cannot be rotated, boxes can only be added to the top of the stack. "
                + "Each bottom box in the stack must be strictly larger in height, width and depth than the box that is on it. "
                + "Implement a method to calculate the height of the tallest stack.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
