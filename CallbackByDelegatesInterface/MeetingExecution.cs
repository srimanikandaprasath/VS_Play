using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    class MeetingExecution
    {
        public void PerformMeeeting()
        {
            IMeeting meeting = new Meeting();
            MeetingRoom meetingStarted = new MeetingRoom("Code Quality improvement");
            meetingStarted.StartMeeting(meeting);
        }
    }
}
