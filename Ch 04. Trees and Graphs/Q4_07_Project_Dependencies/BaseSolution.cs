using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter04.ProjectDependencies
{
    public abstract class BaseSolution : ISolution
    {
        protected IList<(string, string)> Dependencies;
        protected IList<string> Projects;

        protected BaseSolution(IList<string> projects, IList<(string, string)> dependencies)
        {
            this.Projects = projects;
            this.Dependencies = dependencies;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"Projects: {string.Join(", ", Projects)}");
            Console.WriteLine($"Dependency: {string.Join(", ", Dependencies)}");
            var projectOrderBuild = GetProjectOrderBuild();
            Console.Write("GetProjectOrderBuild -> ");

            if (projectOrderBuild == null)
            {
                Console.Write("Error");
            }
            else
            {
                Console.Write(string.Join(", ", projectOrderBuild));
            }
        }

        protected abstract IList<string> GetProjectOrderBuild();
    }
}
