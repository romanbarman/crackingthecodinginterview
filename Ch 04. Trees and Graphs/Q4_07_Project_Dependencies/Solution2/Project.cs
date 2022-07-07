using System.Collections.Generic;

namespace Chapter04.ProjectDependencies.Solution2
{
    public class Project
    {
        private Dictionary<string, Project> dictionary = new Dictionary<string, Project>();

        public Project(string name)
        {
            Name = name;
            Dependencies = 0;
            Children = new List<Project>();
        }

        public string Name { get; }
        public int Dependencies { get; private set; }
        public List<Project> Children { get; }
        public bool IsBuild { get; set; }

        public void AddNeighbor(Project project)
        {
            if (!dictionary.ContainsKey(project.Name))
            {
                dictionary.Add(project.Name, project);
                Children.Add(project);
                project.IncrementDependencies();
            }
        }

        public void IncrementDependencies()
        {
            Dependencies++;
        }

        public void DecrementDependencies()
        {
            Dependencies--;
        }
    }
}
