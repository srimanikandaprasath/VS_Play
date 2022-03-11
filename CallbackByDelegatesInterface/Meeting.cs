using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackByDelegatesInterface
{
    class Meeting : IMeeting
    {
        public void EmployeeAttendedMeeting(string employee)
        {
            Console.WriteLine("Employee Attended Meeting :" + employee);
        }

        public void EmployeeLeftMeeting(string employee)
        {
            Console.WriteLine("Employee Left Meeting :" + employee);
        }

        public void ShowAgenda(string agenda)
        {
            Console.WriteLine("Agenda Details :" + agenda);
        }
    }
}
