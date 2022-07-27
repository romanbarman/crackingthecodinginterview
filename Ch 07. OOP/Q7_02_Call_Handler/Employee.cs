using System;
using System.Threading.Tasks;

namespace Chapter07.CallHandler
{
    public abstract class Employee
    {
        private CallHandler callHandler;
        private Call currentCall;
        private string name;

        protected Employee(string name, CallHandler callHandler)
        {
            this.callHandler = callHandler;
            this.name = name;
        }

        public bool IsFree => currentCall == null;

        public abstract bool HandleCall(Call call);

        protected void SetCall(Call call)
        {
            currentCall = call;
            currentCall.IsHandling = true;

            ProcessCall();
            Console.WriteLine($"{name} starts handle call {call.Number} {call.Complexity}");
        }

        private Task ProcessCall()
        {
            return Task.Run(() =>
            {
                DeleteCall();
            });
        }

        private void DeleteCall()
        {
            callHandler.DeleteCall(currentCall);
            currentCall = null;
        }
    }
}
