using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNotiCallbackInterface
{
    public class MultiTask
    {
        ArrayList notificationObjs = new ArrayList();

        public MultiTask(NotifyClient notifyClient)
        {
            notificationObjs.Add(notifyClient);
        }

        public void AttachCallbacks(NotifyClient notifyClient)
        {
            notificationObjs.Add(notifyClient);
        }
        public void UnAttachCallbacks(NotifyClient notifyClient)
        {
            notificationObjs.Remove(notifyClient);
        }
        public void UnAttachAllCallbacks()
        {
            notificationObjs.Clear();
        }

        public void ProcessSomething()
        {
            for (int counter = 0; counter < 100; counter++)
            {
                if ((counter % 10) == 0)
                {
                    foreach(NotifyClient callback in notificationObjs)
                    {
                        callback.FinishedProcessingSubGroup(counter);
                    }
                }
            }
            foreach (NotifyClient callback in notificationObjs)
            {
                callback.FinishedProcessingGroup();
            }
        }
    }
}
