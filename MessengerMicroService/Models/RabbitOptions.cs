using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    public class RabbitOptions
    {
        public string HostName { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public int Port { get; set; } = 5672;
        public string VHost { get; set; } = "/";
        public string QueueTo { get; set; } = "";
        public string QueueFrom { get; set; } = "";
    }
}
