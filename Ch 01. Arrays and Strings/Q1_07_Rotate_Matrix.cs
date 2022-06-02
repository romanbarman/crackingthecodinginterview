using Contracts;
using System;

namespace Chapter01
{
    public class Q1_07_Rotate_Matrix : IQuestion
    {
        public string GetDescription()
        {
            return "There is an image represented by an NxN matrix; each pixel is represented by 4 bytes. "
                + "Write a method to rotate the image 90 degrees.";
        }

        public void Run()
        {
            var matrix = new int[][]
            {
                new [] {1,2,3,4,5},
                new [] {6,7,8,9,10},
                new [] {11,12,13,14,15},
                new [] {16,17,18,19,20},
                new [] {21,22,23,24,25},
            };

            ShowMatrix(matrix);

            Console.WriteLine("Rotate ->");
            ShowMatrix(Rotate(matrix));

            Console.WriteLine("Rotate2 ->");
            Rotate2(matrix);
            ShowMatrix(matrix);
        }

        private void ShowMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private int[][] Rotate(int[][] image)
        {
            var result = CreateMatrix(image.Length);

            for (var i = 0; i < image.Length; i++)
            {
                for (var j = 0; j < image.Length; j++)
                {
                    result[j][image.Length - i - 1] = image[i][j];
                }
            }

            return result;
        }

        private void Rotate2(int[][] image)
        {
            var layersCount = image.Length / 2;

            for (var layer = 0; layer < layersCount; layer++)
            {
                for (var i = layer; i < image.Length - layer - 1; i++)
                {
                    var tmp = image[layer][i];

                    image[layer][i] = image[image.Length - i - 1][layer];
                    image[image.Length - i - 1][layer] = image[image.Length - layer - 1][image.Length - i - 1];
                    image[image.Length - layer - 1][image.Length - i - 1] = image[i][image.Length - layer - 1];
                    image[i][image.Length - layer - 1] = tmp;
                }
            }
        }

        private int[][] CreateMatrix(int size)
        {
            var result = new int[size][];

            for (var i = 0; i < size; i++)
            {
                result[i] = new int[size];
            }

            return result;
        }
    }
}
