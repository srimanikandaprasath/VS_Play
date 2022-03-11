using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The NotifyClient class shown in Example implements
///the INotificationCallbacks interface. This class contains the
///implementation details for each of the callback methods.
/// </summary>

namespace AddingNotiCallbackInterface
{
    public class NotifyClient : INotificationCallbacks
    {
        public void FinishedProcessingGroup()
        {
            Console.WriteLine("Processing complete");
        }

        public void FinishedProcessingSubGroup(int amount)
        {
            Console.WriteLine("Finished Processing" + amount + "items");
        }
    }
}
