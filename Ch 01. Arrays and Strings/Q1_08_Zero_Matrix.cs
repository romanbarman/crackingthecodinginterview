using Contracts;
using System.Collections.Generic;

namespace Chapter01
{
    public class Q1_08_Zero_Matrix : BaseQuestion
    {
        private static readonly int[][] matrix1 = new int[][]
        {
            new [] {1,0,3,4,5},
            new [] {1,0,3,4,5},
            new [] {1,2,3,4,5},
            new [] {1,2,3,4,0}
        };

        private static readonly int[][] matrix2 = new int[][]
        {
            new [] {1,0,3,4,5},
            new [] {1,0,3,4,5},
            new [] {1,2,3,4,5},
            new [] {1,2,3,4,0}
        };

        private static readonly ISolution[] solutions = new ISolution[]
        {
            new ZeroMatrix.Solution1.Solution(matrix1),
            new ZeroMatrix.Solition2.Solution(matrix2)
        };

        public override string GetDescription()
        {
            return "Write an algorithm that implements the following condition: " +
                "if the element of the matrix MxN is equal to 0, then the entire column and the entire row are set to zero.";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
