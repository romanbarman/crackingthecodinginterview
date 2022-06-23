using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_07_Rotate_Matrix : BaseQuestion
    {
        private static int[,] matix = new[,]
        {
            { 1,  2,  3,  4,  5},
            { 6,  7,  8,  9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };

        private static ISolution[] solutions = new ISolution[]
        {
            new RotateMatrix.Solution1.Solution(matix),
            new RotateMatrix.Solution2.Solution(matix)
        };

        public override string GetDescription()
        {
            return "There is an image represented by an NxN matrix; each pixel is represented by 4 bytes. "
                + "Write a method to rotate the image 90 degrees.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
