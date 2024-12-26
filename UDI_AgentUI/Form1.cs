using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UDI_AgentUI.Handel.DeviceHandel;

using UDI_AgentUI.Handel.Global;
using UDI_AgentUI.Model;
using UDI_AgentUI.Service;
using UDI_AgentUI.Service.SignalR;
using static System.Net.Mime.MediaTypeNames;

namespace UDI_AgentUI
{
    public partial class Form1 : Form
    {
        private readonly IDeviceHandel _deviceHandel;
        private readonly IGlobal _global;
        public string url = "";
        public bool work = true;
        public string errorGuid = "";
        private SignalRClient _signalRClient;
        List<deviceConditoinModel> deviceControlList = new List<deviceConditoinModel>();
        public Form1()
        {
            InitializeComponent();
         
            // DI 注入
            #region DI注入
            var builder = new HostBuilder().ConfigureServices((hostcontext, services) =>
            {
                services.AddScoped<IDBConn, DBConn>();
                services.AddScoped<IGlobal, Global>();
                services.AddScoped<IDeviceHandel, DeviceHandel>();
            });
            var host = builder.Build();
            _global = host.Services.GetRequiredService<IGlobal>();
            _deviceHandel = host.Services.GetRequiredService<IDeviceHandel>();
            #endregion
            InitializeSignalRClient();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            TERAKO_DAS01_Processing.Text = "";
            TERAKO_DAS01_Error.Height = 30;
            TERAKO_DAS01_OrderId.Text = "";
            PX_WAS01_Processing.Text = "";
            PX_WAS01_OrderId.Text = "";
            PX_WAS01_Error.Height = 30;
            ISHIDA_PCRS01_Processing.Text = "";
            ISHIDA_PCRS01_Error.Height = 30;
            ISHIDA_PCRS01_OrderId.Text = "";
            TERAKO_LCU01_Processing.Text = "";
            TERAKO_LCU01_Error.Height = 30;
            TERAKO_DAS01_OrderId.Text = "";

            // 判斷那些設備要顯示
            DataTable dtProfile = _deviceHandel.GetDeviceProfile();
            foreach (DataRow row in dtProfile.Rows)
            {
                string ID = row.Field<string>("ID").ToString();
                string BRAND = row.Field<string>("BRAND").ToString();
                string MODEL = row.Field<string>("MODEL").ToString();

                Control panel = GetElement(BRAND, ID, "Panel");
                if (panel != null)
                {
                    panel.Visible = true;
                }
            }

            initialDeviceControlData();


            url = @"C:\UDI";




        }

        // 取得 指示名稱
        public string orderTypeName(byte orderId)
        {
            string orderTypeName = "";
            try
            {
                var res = _deviceHandel.GetOrderType();
                var orderType = res.AsEnumerable().FirstOrDefault(r => r.Field<byte>("TYPE") == orderId);
                orderTypeName = orderType.Field<string>("NAME");
            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }

            return orderTypeName;
        }


        // 監控 有沒有指示，有指示呼叫 EXE
        private async void tmrAgent_Tick(object sender, EventArgs e)
        {
            try
            {

                // 取得 指示
                DataSet dataSet = await _deviceHandel.GetNewTaskID();

                if (dataSet.Tables.Count == 0)
                {
                    return;
                }

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    #region 取得呼叫 exe 需要的參數資料
                    string taskId = row.Field<Guid>("TASK_ID").ToString();
                    int orderID = row.Field<int>("ORDER_ID");
                    string guid = row.Field<Guid>("GUID").ToString();
                    byte orderType = row.Field<byte>("ORDER_TYPE");
                    string brand = row.Field<string>("BRAND");
                    string agent = row.Field<string>("AGENT");
                    string hostIP = row.Field<string>("HOST_IP");
                    string id = row.Field<string>("ID");
                    // 將參數組合起來
                    string parameters = $"{hostIP ?? "123"} {guid} {orderType} {orderID} {taskId}";

                    string appPath = "";

                    //appPath = $@"D:\Users\Jones_Zhong\Desktop\Asp專案\LCU_Agent\執行檔\{brand}\{id}\{agent}";
                    
                    appPath = $@"{url}\{brand}\{id}\{agent}";
                    #endregion


                    // 呼叫 exe
                    #region 呼叫 exe 並傳遞參數，註冊關閉事件
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = appPath, // 替换为你的控制台应用程序的路径
                        Arguments = parameters,       // 替换为你要传递的参数
                        UseShellExecute = false,
                        RedirectStandardOutput = false,   // 如果需要读取控制台输出
                        RedirectStandardError = false,    // 如果需要读取控制台错误输出

                    };

                    Process process = new Process
                    {
                        StartInfo = startInfo,
                        EnableRaisingEvents = true
                    };

                    // 當應用程序退出時，會觸發 ConsoleAppExited 事件。
                    process.Exited += (s, args) => ConsoleAppExited(s, new ConsoleAppExitedEventArgs(brand, taskId, guid, id));
                    //process.WaitForExit();
                    process.Start();
                    #endregion

                    Control elementError = GetElement(brand, id, "EXE");
                    elementError.Visible = true;

                }
            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }
        }
        /**
         * exe 關閉的時候，會通知
         */
        private void ConsoleAppExited(object sender, ConsoleAppExitedEventArgs e)
        {
            Control elementEXE = GetElement(e.Brand, e.Id, "EXE");
            elementEXE.Invoke(new Action(() => { elementEXE.Visible = false; }));

            //Control elementDevice = GetElement(e.Brand, e.Id, "Device");
            //PictureBox pictureBox = elementDevice as PictureBox;
            //pictureBox.Image = Properties.Resources.devive_close;

        }



        //  取得 開啟初始 設備資料
        private void initialDeviceControlData()
        {
            try
            {

                var dataTable = _deviceHandel.getInitDeviceControl();

                foreach (DataRow row in dataTable.Rows)
                {
                    deviceConditoinModel deviceConditoinModel = new deviceConditoinModel();

                    deviceConditoinModel.DEVICE_ID = row["DEVICE_ID"].ToString();
                    deviceConditoinModel.ORDER_ID = (int)row["ORDER_ID"];
                    deviceConditoinModel.TASK_ID = row["TASK_ID"].ToString();
                    deviceConditoinModel.BREATHING_ORDER = (byte)row["BREATHING_ORDER"];
                    deviceConditoinModel.BREATHING_ALARM = row["BREATHING_ALARM"].ToString();
                    deviceConditoinModel.BREATHING_LIGHT = row["BREATHING_LIGHT"].ToString();
                    deviceConditoinModel.STATE = (byte)row["STATE"];

                    deviceControlList.Add(deviceConditoinModel);
                }

                uiControl();
            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }
        }

        // 初始化 SignalR
        private async void InitializeSignalRClient()
        {
            try
            {
                string signalrUrl = ConfigurationManager.AppSettings["signalR"].ToString();
                // 初始化 SignalRClient 实例，并设置服务器 URL
                //_signalRClient = new SignalRClient("http://172.20.20.23/signalR/udi_device_contrl/SignalServer");
                _signalRClient = new SignalRClient(signalrUrl);
            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }


            // 订阅 OnMessageReceived 事件，当收到消息时更新 UI
            _signalRClient.OnMessageReceived += (message) =>
            {

                deviceControlList = JsonSerializer.Deserialize<List<deviceConditoinModel>>(message);
                uiControl();
            };
        }


        // 渲染畫面
        public void uiControl()
        {
            foreach (deviceConditoinModel device in deviceControlList)
            {
                string brand = _global.getDeviceBrnad(device.DEVICE_ID);
                string deviceId = device.DEVICE_ID;
                string handel = device.BREATHING_LIGHT.Trim();
                string alarm = device.BREATHING_ALARM.Trim();
                int orderId = device.ORDER_ID;
                string taskId = device.TASK_ID;
                byte orderType = (byte)device.BREATHING_ORDER;
                int state = device.STATE;

                // 取得物件
                Control elementProcessing = GetElement(brand, deviceId, "Processing");
                Control elementError = GetElement(brand, deviceId, "Error");
                Control elementOrderId = GetElement(brand, deviceId, "OrderId");
                Control elementDevice = GetElement(brand, deviceId, "Device");
                PictureBox pictureBox = elementDevice as PictureBox;

                // 判斷開關顏色
                if (state == 1)
                {
                    pictureBox.Image = Properties.Resources.decive_open;
                }
                else if (state == 2)
                {
                    pictureBox.Image = Properties.Resources.devive_close;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.devive_handel;
                }


                if (elementOrderId == null || elementError == null || elementProcessing == null)
                {
                    _deviceHandel.Agent_WriteLog("找不到物件");
                    return;
                }

                // 單號
                elementOrderId.Invoke(new Action(() => { elementOrderId.Text = orderId.ToString(); }));


                // 顯示執行動作、錯誤訊息
                if (handel == "#0E0" && alarm == "#300")
                {
                    elementProcessing.ForeColor = Color.Green;
                    elementProcessing.Invoke(new Action(() => { elementProcessing.Text = orderTypeName(orderType); }));
                    elementError.Invoke(new Action(() => { elementError.Text = ""; }));

                }
                else if (alarm == "#E00")
                {
                    elementProcessing.ForeColor = Color.Red;
                    string errorMsg = _deviceHandel.GetError(deviceId, orderId);
                    elementError.Invoke(new Action(() => { elementError.Text = errorMsg; }));

                }
                else
                {
                    elementProcessing.ForeColor = Color.Black;
                    elementError.Invoke(new Action(() => { elementError.Text = ""; }));
                    elementProcessing.Invoke(new Action(() => { elementProcessing.Text = ""; }));
                }
            }
        }


        /*
         *  取得 UI 物件
         */
        public Control GetElement(string brand, string id, string handel)
        {
            Control foundControl = null;
            try
            {
                string processingElement = $"{brand}_{id}_{handel}";
                foundControl = this.Controls.Find(processingElement, true).FirstOrDefault();

            }
            catch (Exception ex)
            {

                _deviceHandel.Agent_WriteLog(ex.Message);
            }
            return foundControl;
        }


        // 打開LOG 紀錄
        private void Reader_Record_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                string folderPath = $@"{url}\{btn.Tag}\Log";
                // 获取指定文件夹中的所有文本文件
                var textFiles = Directory.GetFiles(folderPath, "*.txt", SearchOption.TopDirectoryOnly);

                // 如果文件夹中没有文本文件，提示并返回
                if (textFiles.Length == 0)
                {
                    return;
                }

                // 查找最后修改日期最晚的文件
                var latestFile = textFiles
                    .Select(file => new FileInfo(file))
                    .OrderByDescending(file => file.LastWriteTime)
                    .FirstOrDefault();

                // 打开文件
                if (latestFile != null)
                {
                    Process.Start(new ProcessStartInfo(latestFile.FullName) { UseShellExecute = true });
                    Console.WriteLine($"Opened file: {latestFile.FullName}");
                }
            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }
        }

        /***
        錯誤處理
        ***/
        // 處理 修復 按鈕事件
        private void HandleError_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                string deviceId = btn.Tag.ToString();


                int orderId = deviceControlList.Find(x => x.DEVICE_ID == deviceId).ORDER_ID;

                _deviceHandel.HandleError(deviceId, orderId);

            }
            catch (Exception ex)
            {
                _deviceHandel.Agent_WriteLog(ex.Message);
            }
        }




        /*
         * 監聽 
         */

        // 執行 LEO 監聽 設備狀態 SP
        private async void listen_Tick(object sender, EventArgs e)
        {
            listen.Enabled = false;
            await _deviceHandel.devListen();
            await _deviceHandel.appListen();
            listen.Enabled = true;
        }

        // 監聽 下指示主檔
        private void assign_Tick(object sender, EventArgs e)
        {
            assign.Enabled = false;
            _deviceHandel.Assign();
            assign.Enabled = true;
        }

        // 監聽 回收實績
        private void result_Tick(object sender, EventArgs e)
        {
            result.Enabled = false;
            _deviceHandel.Result();
            result.Enabled = true;
        }


        // 移除 LOG
        public async Task removeLog(string brand, string deviceId)
        {
            const int BatchSize = 100;
            string folderPath = $@"C:\\UDI\\{brand}\\{deviceId}\\" + @"Log";
            if (Directory.Exists(folderPath))
            {
                try
                {
                    // 获取文件夹中所有文件
                    string[] files = Directory.GetFiles(folderPath);
                    DateTime currentDate = DateTime.Now;

                    // 将文件分成多个批次
                    var batches = files.Select((file, index) => new { file, index })
                                       .GroupBy(x => x.index / BatchSize)
                                       .Select(g => g.Select(x => x.file).ToList());

                    foreach (var batch in batches)
                    {
                        await Task.Run(() =>
                        {
                            foreach (var file in batch)
                            {
                                DateTime fileCreationTime = File.GetCreationTime(file);
                                if ((currentDate - fileCreationTime).TotalDays > 3)
                                {
                                    File.Delete(file);
                                }
                            }
                        });

                        // 等待 100 毫秒，避免文件系统过载
                        await Task.Delay(100);
                    }

                    //_deviceHandel.Agent_WriteLog("六小時前的文件已刪除，刪除成功");
                }
                catch (Exception ex)
                {
                    _deviceHandel.Agent_WriteLog("删除文件時出錯: " + ex.Message);
                }
            }
            else
            {
                //_deviceHandel.Agent_WriteLog("指定的文件夾不存在。"+ folderPath);
            }
        }

        // 移除備份檔案
        public async Task removeBackup(string brand, string deviceId)

        {

            const int BatchSize = 100;
            string folderPath = $@"C:\\UDI\\{brand}\\{deviceId}\\{brand}";
            if (Directory.Exists(folderPath))
            {
                try
                {
                    // 获取文件夹中所有文件
                    string[] directorys = Directory.GetDirectories(folderPath);
                    DateTime currentDate = DateTime.Now;

                    // 将文件分成多个批次
                    var batches = directorys.Select((file, index) => new { file, index })
                                       .GroupBy(x => x.index / BatchSize)
                                       .Select(g => g.Select(x => x.file).ToList());

                    foreach (var batch in batches)
                    {


                        await Task.Run(() =>
                        {
                            foreach (var directory in batch)
                            {
                                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                                if (directoryInfo.LastWriteTime <= DateTime.Now.AddDays(-3))
                                {
                                    Directory.Delete(directory, true);
                                }
                            }
                        });

                        // 等待 100 毫秒，避免文件系统过载
                        await Task.Delay(100);
                    }

                    //_deviceHandel.Agent_WriteLog("3天前的文件已刪除，刪除成功");
                }
                catch (Exception ex)
                {
                    _deviceHandel.Agent_WriteLog("删除文件時出錯: " + ex.Message);
                }
            }
            else
            {

                //_deviceHandel.Agent_WriteLog("指定的文件夾不存在。"+ folderPath);
            }
        }

        private async void clearLog_Tick(object sender, EventArgs e)
        {
            clearLog.Enabled = false;
            await removeLog("ISHIDA", "PCRS01");
            await removeLog("TERAKO", "LCU01");
            await removeLog("TERAKO", "DAS01");
            await removeLog("PX", "WAS01");
            await removeBackup("ISHIDA", "PCRS01");
            await removeBackup("TERAKO", "LCU01");
            await removeBackup("TERAKO", "DAS01");
            await removeBackup("PX", "WAS01");
            clearLog.Enabled = true;
        }
    }

    /*
     * 動態取得 UI 物件實體名稱
     */
    public class ConsoleAppExitedEventArgs : EventArgs
    {
        public string Brand { get; }
        public string TaskId { get; }

        public string Guid { get; set; }

        public string Id { get; set; }

        public ConsoleAppExitedEventArgs(string brand, string taskId, string guid, string id)
        {
            Brand = brand;
            TaskId = taskId;
            Guid = guid;
            Id = id;
        }
    }
}
