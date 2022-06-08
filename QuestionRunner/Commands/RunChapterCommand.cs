using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuestionRunner.Commands
{
    class RunChapterCommand : ICommand
    {
        private readonly IEnumerable<IQuestion> questions;

        public RunChapterCommand(int commandNumber, string title, Type questionType)
        {
            CommandNumber = commandNumber;
            Title = title;

            var iQuestionTypes = questionType.Assembly.GetTypes()
                                .Where(p => typeof(IQuestion).IsAssignableFrom(p) && !p.IsInterface && string.Equals(p.Namespace, questionType.Namespace, StringComparison.OrdinalIgnoreCase))
                                .OrderBy(p => int.Parse(p.Name.Split('_')[1]));

            questions = iQuestionTypes.Select(t => (IQuestion)Activator.CreateInstance(t));
        }

        public int CommandNumber { get; }

        public string Title { get; }

        public void Run()
        {
            Console.Clear();

            foreach (var question in questions)
            {
                Console.WriteLine(question.GetDescription());
                Console.WriteLine();
                question.Run();

                Console.WriteLine(new string('-', 120));
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
