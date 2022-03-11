using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    class MeetingRoom
    {
        private string message;
        public MeetingRoom(string message)
        {
            this.message = message;
        }

        public void StartMeeting(IMeeting meeting)
        {
            //its a callback
            if (meeting != null) meeting.ShowAgenda(message);
        }
    }
}
