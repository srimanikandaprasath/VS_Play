using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Tut
{
    class DataPacket
    {
        public DataPacket()
        {

        }

        public string sTestGroup { get; set; }
        public string sPC_No { get; set; }
        public string sConnection { get; set; }
        public string nParaCount { get; set; }
        public string sCommand_S0 { get; set; }
        public string sCommand_S1 { get; set; }
        public string sCommand_Gen { get; set; }
    }
}
