using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDI_AgentUI.Handel.DeviceHandel;

namespace UDI_AgentUI.Service.SignalR
{
    public class SignalRClient
    {


        private HubConnection _connection;


        // 定义一个事件用于通知主窗体有新的数据
        public event Action<string> OnMessageReceived;

        public SignalRClient(string url)
        {

            SignalRConnection(url);
        }

        public async void SignalRConnection(string url)
        {

            DeviceHandel deviceHandel = new DeviceHandel();
            _connection = new HubConnectionBuilder()
                  .WithUrl(url).WithAutomaticReconnect().Build();


            //連線中斷並準備進行自動重連時，會觸發這個事件。
            _connection.Reconnecting += error =>
            {
                deviceHandel.Agent_WriteLog($"連線中斷並準備進行自動重連，Reconnecting: {error?.Message}");
                return Task.CompletedTask;
            };

            //成功重新連線到伺服器時，會觸發這個事件
            _connection.Reconnected += connectionId =>
            {
                deviceHandel.Agent_WriteLog($"成功重新連線到伺服器，Reconnected with ID: {connectionId}");
                return Task.CompletedTask;
            };

            await _connection.StartAsync();


            // 連線意外中斷且無法恢復時觸發
            _connection.Closed +=  (error) =>
            {
                deviceHandel.Agent_WriteLog($"連線意外中斷且無法恢復時觸發，Connection closed: {error?.Message}");
                return Task.CompletedTask; // 不需手動重連
            };


            _connection.On<string>("refreshDeviceControl", message =>
            {
                // 触发事件，通知有新消息到达
                OnMessageReceived?.Invoke(message);
            });

        }





        public async Task StartAsync()
        {
            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {

            }

        }

        public async Task SendMessageAsync(string message)
        {
            if (_connection.State == HubConnectionState.Connected)
            {
                await _connection.InvokeAsync("SendMessage", message);
            }
        }

        public async Task StopAsync()
        {
            await _connection.StopAsync();
        }
    }
}
