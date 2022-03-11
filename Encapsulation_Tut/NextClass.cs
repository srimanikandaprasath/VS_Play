using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Tut
{
    class NextClass
    {
        DataPacket obj2 = new DataPacket();
        public void test1()
        {
            obj2.sCommand_Gen = "Gencommand-2";
            //Console.WriteLine(obj2.sCommand_Gen);
        }
       
    }
}
