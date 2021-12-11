using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using class_lib_try;

namespace ThreadsAsync
{
    class JobDoer
    {
        private bool isWorking = false;

        public void doJob()
        {
            while (isWorking)
            {
                Context context = TaskQueue.next();
                if (context == null)
                {
                    continue;
                }

                Thread.Sleep(Convert.ToInt32(context.TaskDelay));
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " отработал");
            }
        }

        public bool IsWorking
        {
            get => isWorking;
            set => isWorking = value;
        }
    }
}
