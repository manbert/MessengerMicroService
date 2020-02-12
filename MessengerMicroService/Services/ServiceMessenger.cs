using MessengerMicroService.Models;
using MessengerMicroService.RabbitMQ;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MessengerMicroService.Services
{
    public class ServiceMessenger : BackgroundService
    {
        private IRabbitManager _manager;

        public ServiceMessenger(IRabbitManager manager)
        {
            _manager = manager;
        }        

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {            
            while (!stoppingToken.IsCancellationRequested)
            {
                GetMessages();
                await Task.Delay(10000, stoppingToken);
            }
        }

        //забираем сообщения с мессенджеров
        private void GetMessages()
        {           
            var message = new Message { ChatId = Guid.NewGuid().ToString(), Text = Guid.NewGuid().ToString(), TimeStamp = DateTime.Now, ClientInfo = new ClientInfo() { Phone = "+7" + (new Random().Next(1000000, 9999999)) + (new Random().Next(100, 999)) } };
            _manager.Publish(message, "from_messenger");
            Debug.WriteLine($"Publish from_messenger: { JsonConvert.SerializeObject(message) } ");
        }
    }
}
