using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chapter07.CallHandler
{
    public class CallHandler
    {
        private readonly List<Operator> operators;
        private readonly HashSet<Call> calls = new HashSet<Call>();
        private object locker = new object();
        private bool isStartHandle = false;

        public CallHandler()
        {
            var director = new Director("Director", this);

            var manager1 = new Manager("Manager 1", this, director);
            var manager2 = new Manager("Manager 2", this, director);

            operators = new List<Operator>
            {
                new Operator("Operator 1", this, manager1),
                new Operator("Operator 2", this, manager1),
                new Operator("Operator 3", this, manager2),
                new Operator("Operator 4", this, manager2),
            };
        }

        public Task Handler { get; private set; }

        public void GetNew(Call newCall)
        {
            lock (locker)
            {
                calls.Add(newCall);
            }

            if (!isStartHandle)
            {
                Handler = StartHandle();
                isStartHandle = true;
            }
        }

        public void DeleteCall(Call call)
        {
            lock (locker)
            {
                calls.Remove(call);
            }
        }

        private Task StartHandle()
        {
            return Task.Run(() =>
            {
                while (calls.Count > 0)
                {
                    Task.Delay(100);

                    lock (locker)
                    {
                        foreach (var call in calls)
                        {
                            if (call.IsHandling)
                            {
                                continue;
                            }

                            var isHandled = false;
                            var allOpeartorsHandle = true;

                            foreach (var employee in operators)
                            {
                                if (employee.IsFree && employee.HandleCall(call))
                                {
                                    isHandled = true;
                                    allOpeartorsHandle = false;
                                    break;
                                }
                            }

                            if (!isHandled)
                            {
                                Console.WriteLine($"The call {call.Number} {call.Complexity} is not handled");
                            }

                            if (allOpeartorsHandle)
                            {
                                break;
                            }
                        }
                    }
                }
            });
        }
    }
}
