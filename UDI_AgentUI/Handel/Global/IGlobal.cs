using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI_AgentUI.Handel.Global
{
    internal interface IGlobal
    {
        public string oderTypeName(string num);

        public string getDeviceBrnad(string deviceId);
    }
}
