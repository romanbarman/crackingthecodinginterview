using Contracts;
using System;

namespace Chapter07.CallHandler
{
    public class Solution : ISolution
    {
        private readonly CallHandler callHandler = new CallHandler();

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            var random = new Random();
            for (int i = 0; i < 15; i++)
            {
                var randomNumber = random.Next(6);
                var complexity = Complexity.ForOperator;

                if (randomNumber > 2 && randomNumber < 5)
                {
                    complexity = Complexity.ForManager;
                }

                if (randomNumber == 5)
                {
                    complexity = Complexity.ForDirector;
                }

                var call = new Call(complexity, i);
                callHandler.GetNew(call);
            }

            callHandler.Handler.Wait();
        }
    }
}
