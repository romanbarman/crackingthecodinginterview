using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.Robot
{
    public class Solution : ISolution
    {
        private bool[,] maze;

        public Solution(bool[,] maze)
        {
            this.maze = maze;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Maze:");
            ShowMaze();

            var path = GetPath();

            Console.WriteLine($"HasPath -> {path != null}");

            if (path != null)
            {
                foreach (var point in path)
                {
                    Console.WriteLine(point);
                }
            }
        }

        private void ShowMaze()
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write($"{(maze[i, j] == false ? 0 : 1)} ");
                }

                Console.WriteLine();
            }
        }

        private List<Point> GetPath()
        {

            var points = new List<Point>();
            var cache = new Dictionary<Point, bool>();

            if (HasPath(maze.GetLength(0) - 1, maze.GetLength(1) - 1, points, cache))
            {
                return points;
            }

            return null;
        }

        private bool HasPath(int i, int j, List<Point> points, Dictionary<Point, bool> cache)
        {
            if (i < 0 || j < 0 || maze[i, j] == true)
            {
                return false;
            }

            var point = new Point(i, j);

            if (cache.ContainsKey(point))
            {
                return cache[point];
            }

            var isOrigin = i == 0 && j == 0;
            var isSuccess = false;

            if (isOrigin || HasPath(i - 1, j, points, cache) || HasPath(i, j - 1, points, cache))
            {
                points.Add(point);
                isSuccess = true;
            }

            cache[point] = isSuccess;
            return isSuccess;
        }
    }
}
