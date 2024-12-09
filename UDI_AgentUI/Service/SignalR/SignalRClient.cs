using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDI_AgentUI.Service.SignalR
{
    public class SignalRClient
    {
        private HubConnection _connection;

        // 定义一个事件用于通知主窗体有新的数据
        public event Action<string> OnMessageReceived;

        public  SignalRClient(string url)
        {

            SignalRConnection(url);
        }

        public async void SignalRConnection(string url)
        {
            _connection = new HubConnectionBuilder()
                  .WithUrl(url)
                  .Build();
            await _connection.StartAsync();



            _connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await _connection.StartAsync();
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
            }catch (Exception ex)
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
