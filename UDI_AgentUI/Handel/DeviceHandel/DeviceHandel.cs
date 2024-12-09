using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI_AgentUI.Service;

namespace UDI_AgentUI.Handel.DeviceHandel
{
    internal class DeviceHandel:IDeviceHandel
    {
        private readonly IDBConn _dbConn;

        public DeviceHandel()
        {

        }

        public DeviceHandel(IDBConn dBConn)
        {
            _dbConn = dBConn;
        }


        //  取得 開啟初始 設備資料
        public DataTable getInitDeviceControl()
        {
            string strSql = @"SELECT * FROM [dev].[UDI_CONTROL]";
            Hashtable hashtable = new Hashtable();

            DataSet dataSet = _dbConn.SqlQuery("UDI", strSql, hashtable);
            return dataSet.Tables[0];
        }

        // 監控 有沒有指示，有指示呼叫 EXE
        public async Task<DataSet> GetNewTaskID()
        {

            string strSp = @"get.spUDI_ORDER";
            Hashtable prm = new Hashtable();
            DataSet dataSet = await _dbConn.SqlSp("UDI", strSp, prm);
            return dataSet;
        }

        // 執行 LEO 監聽 設備狀態 SP
        public async Task devListen()
        {
            string strSp = @"[dev].[spUDI_LISTEN]";
            Hashtable prm = new Hashtable();
            await _dbConn.SqlSp("UDI", strSp, prm);
        }

        public async Task appListen()
        {
            string strSp = @"[app].[spUDI_LISTEN]";
            Hashtable prm = new Hashtable();
            await _dbConn.SqlSp("UDI", strSp, prm);
        }

        //public string GetDoneTime(string guid)
        //{
        //    string doneTimeString = "";
        //    string strSp = @"SELECT DONE_TIME FROM [dbo].[UDI_STATE] WHERE GUID = @GUID";
        //    Hashtable hashtable = new Hashtable();
        //    hashtable.Add("GUID", guid);
        //    DataSet dataSet = _dbConn.SqlQuery("UDI", strSp, hashtable);
        //    DataTable dataTable = dataSet.Tables[0];
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        DataRow row = dataTable.Rows[0];
        //        doneTimeString = row["DONE_TIME"].ToString();
        //    }

        //    return doneTimeString;
        //}

        // 取得錯誤訊息
        public string GetError(string objectId,int orderId)
        {
            string errorMsg = "";
            string strSql = @"SELECT TOP 1 LOG_TIME,MSG
                                FROM [dbo].[UDI_ORDER] O
                               INNER JOIN [dbo].[UDI_STATE] S
                                  ON O.TASK_ID = S.TASK_ID
                               INNER JOIN [log].[UDI_ERROR] E
                                  ON S.GUID = E.GUID
                               WHERE O.OBJECT_ID = @OBJECT_ID
                                 AND O.ORDER_ID = @ORDER_ID
                               ORDER BY E.LOG_TIME DESC";
            Hashtable hashtable = new Hashtable();
            hashtable.Add("OBJECT_ID", objectId);
            hashtable.Add("ORDER_ID", orderId);
            DataSet dataSet = _dbConn.SqlQuery("UDI", strSql, hashtable);
            DataTable dataTable = dataSet.Tables[0];
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

               
                errorMsg = row["LOG_TIME"].ToString() +" " +row["MSG"].ToString();
            };
            return errorMsg;
        }

        // 監聽 下指示主檔
        public async Task Assign()
        {
            string strSp = @"[app].[spUDI_GET_PX_i56_ASSIGN]";
            Hashtable prm = new Hashtable();
            await _dbConn.SqlSp("UDI", strSp, prm);
        }

        // 監聽 回收實績
        public async Task Result()
        {
            string strSp = @"[get].[spUDI_RESULT]";
            Hashtable prm = new Hashtable();
            await _dbConn.SqlSp("UDI", strSp, prm);
        }

        // 取得 指示名稱
        public DataTable GetOrderType()
        {
            string strSql = @"SELECT TYPE,NAME FROM [dbo].[UDI_ORDER_TYPE]";
            Hashtable prm = new Hashtable();
            var res = _dbConn.SqlQuery("UDI", strSql, prm);
            return res.Tables[0];
        }

        // 判斷那些設備要顯示
        public DataTable GetDeviceProfile()
        {
            string strSql = @"SELECT ID,BRAND,MODEL FROM [dev].[UDI_PROFILE]";
            Hashtable prm = new Hashtable();
            var res = _dbConn.SqlQuery("UDI", strSql, prm);
            return res.Tables[0];
        }

        //錯誤處理
        public async Task HandleError(string deviceId, int orderId)
        {

            string strSp = @"[system].[spUDI_STATE]";

            Hashtable prm = new Hashtable();
            prm.Add("DEVICE_ID", deviceId);
            prm.Add("ORDER_ID", orderId);
            await _dbConn.SqlSp("UDI", strSp, prm);

        }

        // LOG 錯誤訊息
        public void Agent_WriteLog(string msg)
        {
            string FilePath = AppDomain.CurrentDomain.BaseDirectory + @"Log\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"Log");



            //這樣可以確保在該執行緒執行寫入操作期間，其他執行緒無法進行寫入或讀取操作。
            ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();
            _readWriteLock.EnterWriteLock();

            //FileMode.Append 表示如果檔案存在，會將資料附加到檔案的末尾，如果檔案不存在，則會建立新的檔案。
            //FileAccess.Write 表示可以對檔案進行寫入操作。
            //FileShare.ReadWrite 表示允許多個讀取和寫入操作。
            using (FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default, 4096))
                {
                    string space = new string(' ', 5);
                    string txtMsg = $"{DateTime.Now.ToString("HH:mm:ss")} 錯誤 : {msg}";
                    sw.WriteLine(txtMsg);
                    sw.Close();
                }
            }
            _readWriteLock.ExitWriteLock();
        }
    }
}
