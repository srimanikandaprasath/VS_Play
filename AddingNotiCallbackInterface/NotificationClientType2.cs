using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNotiCallbackInterface
{
    public class NotificationClientType2 : INotificationCallbacks
    {
        public void FinishedProcessingGroup()
        {
            Console.WriteLine("[Type2] Processing complete");
        }

        public void FinishedProcessingSubGroup(int amount)
        {
            Console.WriteLine("[Type2]Finished processing " + amount + " items");
        }
    }
}
