using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    public class Message: IMessage
    {
        //скорее всего больше свойств
        public ClientInfo ClientInfo { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ChatId { get; set; }
    }
}
