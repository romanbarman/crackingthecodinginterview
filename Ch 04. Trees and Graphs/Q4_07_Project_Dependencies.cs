using Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04
{
    public class Q4_07_Project_Dependencies : BaseQuestion
    {
        private static IList<string> projects = new List<string> { "a", "b", "c", "d", "e", "f" };
        private static IList<(string, string)> projectsDependencies = new List<(string, string)>
        {
            ("d", "a"), ("b", "f"), ("d", "b"), ("a", "f"), ("c", "d")
        };
        private static ISolution[] solutions = new ISolution[]
        {
            new ProjectDependencies.Solution1.Solution(projects.ToList(), projectsDependencies.ToList()),
            new ProjectDependencies.Solution2.Solution(projects.ToList(), projectsDependencies.ToList())
        };

        public override string GetDescription()
        {
            return "";
        }

        protected override IList<ISolution> GetSolutions()
        {
            return solutions;
        }
    }
}
