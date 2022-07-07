using System.Collections.Generic;

namespace Chapter04.ProjectDependencies.Solution1
{
    public class Solution : BaseSolution
    {
        public Solution(IList<string> projects, IList<(string, string)> projectsDependencies) : base(projects, projectsDependencies) { }

        protected override IList<string> GetProjectOrderBuild()
        {
            var list = new List<string>();

            while (Projects.Count != 0)
            {
                var project = GetProjectWithoutDependency();

                if (project == null)
                {
                    return null;
                }

                list.Add(project);
                Remove(project);
            }

            return list;
        }

        private void Remove(string project)
        {
            Projects.Remove(project);

            var list = new List<(string, string)>();

            foreach (var projectDependency in Dependencies)
            {
                if (projectDependency.Item2 == project)
                {
                    list.Add(projectDependency);
                }
            }

            foreach (var item in list)
            {
                Dependencies.Remove(item);
            }
        }

        private string GetProjectWithoutDependency()
        {
            foreach (var project in Projects)
            {
                bool hasDependency = false;
                foreach (var projectDependency in Dependencies)
                {
                    if (projectDependency.Item1 == project)
                    {
                        hasDependency = true;
                        break;
                    }
                }

                if (!hasDependency)
                {
                    return project;
                }
            }

            return null;
        }
    }
}
