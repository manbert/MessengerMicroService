using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    public class MessengerConfig
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string SecretKey { get; set; }
    }
}
