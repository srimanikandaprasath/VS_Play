using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    public delegate void TaskCompletedCallback(string taskResult);

    class Callback
    {
        public void StartNewTask(TaskCompletedCallback taskCompletedCallback)
        {
            Console.WriteLine("I have started new task");
            if (taskCompletedCallback != null)
                taskCompletedCallback("I have completed Task");
        }
    }
}
