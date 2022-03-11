using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    class CallbackTest
    {
        public void Test()
        {
            TaskCompletedCallback callback = TestCallBack;
            Callback testCallback = new Callback();
            testCallback.StartNewTask(TestCallBack);

        }

        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }
}
