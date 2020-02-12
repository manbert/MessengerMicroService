using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    public class ClientInfo: IClientInfo
    {
        public string Phone { get; set; }
        public string ClientType { get; set; }              
    }
}
