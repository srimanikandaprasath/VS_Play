using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    public interface IMeeting
    {
        void ShowAgenda(string agenda);
        void EmployeeAttendedMeeting(string employee);
        void EmployeeLeftMeeting(string employee);
    }
}
