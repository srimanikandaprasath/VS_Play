using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Use an interface to provide callback methods. The
///INotificationCallbacks interface contains two methods that will
///be used by a client as callback methods.The first method,
///FinishedProcessingSubGroup, is called when an amount specified
///in the amount parameter is reached.The second method,
//FinishedProcessingGroup, is called when all processing is complete:
/// </summary>
/// 

//Implementing the INotificationCallbacks interface

namespace AddingNotiCallbackInterface
{
    interface INotificationCallbacks
    {
        void FinishedProcessingSubGroup(int amount);
        void FinishedProcessingGroup();
    }
}
