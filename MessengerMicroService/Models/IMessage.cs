using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    interface IMessage
    {
        ClientInfo ClientInfo { get; set; }
        string Text { get; set; }
        DateTime TimeStamp { get; set; }
        string ChatId { get; set; }
    }
}
