using MessengerMicroService.Models;
using MessengerMicroService.RabbitMQ;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace MessengerMicroService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessengerController : ControllerBase
    {
        private readonly IRabbitManager _manager;        

        public MessengerController(IRabbitManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public Result Send(Message message)
        {            
            _manager.Publish(message, "to_messenger");
            return new Result { Succes = true };
        }

        [HttpGet]
        public Result Answer(ClientInfo clientInfo)
        {
           
            return new Result { Succes = true };
        }

        [HttpGet]
        public ActionResult<Message> GetMessage()
        {            
            var message = new Message { ChatId = Guid.NewGuid().ToString(), Text = Guid.NewGuid().ToString(), TimeStamp = DateTime.Now, ClientInfo = new ClientInfo() { Phone = "+7" + (new Random().Next(1000000, 9999999)) + (new Random().Next(100, 999)) } };
            return message;
        }
    }
}