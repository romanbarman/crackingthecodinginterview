using System;
using System.Collections.Generic;

namespace Contracts
{
    public abstract class BaseQuestion : IQuestion
    {
        public abstract string GetDescription();

        public void Run()
        {
            var solutions = GetSolutions();
            if (solutions.Count == 1)
            {
                Console.WriteLine("Solution");

                RunSolution(solutions[0]);
            }
            else
            {
                var i = 1;

                foreach (var solution in solutions)
                {
                    Console.WriteLine($"Solution {i}");

                    RunSolution(solution);

                    i++;
                }
            }
        }

        private void RunSolution(ISolution solution)
        {
            if (solution.HasComment)
            {
                Console.WriteLine(solution.GetComment());
            }

            solution.Run();
            Console.WriteLine();
        }

        protected abstract IList<ISolution> GetSolutions();
    }
}
