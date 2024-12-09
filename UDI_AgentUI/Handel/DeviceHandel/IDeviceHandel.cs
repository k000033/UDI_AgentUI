using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI_AgentUI.Handel.DeviceHandel
{
    internal interface IDeviceHandel
    {
        public Task<DataSet> GetNewTaskID();
        public Task devListen();
        public Task appListen();
        public Task Assign();

        public Task Result();

        public DataTable getInitDeviceControl();

        public DataTable GetOrderType();

        //public string GetDoneTime(string guid);

        public string GetError(string objectId, int orderId);

        public Task HandleError(string deviceId, int orderId);


        public void Agent_WriteLog(string msg);

        public DataTable GetDeviceProfile();
    }
}
