using Contracts;
using System.Collections.Generic;

namespace Chapter08
{
    public class Q8_02_Robot : BaseQuestion
    {
        public override string GetDescription()
        {
            return "The robot stands in the upper left corner of the grid, consisting of p rows and c columns. "
                + "The robot can move in two directions: to the right and down, but some cells of the grid are blocked, "
                + "that is, the robot cannot pass through them. "
                + "Develop an algorithm for constructing a route from the upper left to the lower right corner";
        }

        protected override IList<ISolution> GetSolutions()
        {
            var maze = new bool[5, 5];
            maze[1, 3] = true;
            maze[2, 0] = true;
            maze[2, 1] = true;
            maze[2, 2] = true;
            maze[2, 3] = true;

            return new ISolution[] { new Robot.Solution(maze) };
        }
    }
}
