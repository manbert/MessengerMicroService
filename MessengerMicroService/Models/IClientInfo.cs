using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    interface IClientInfo
    {
        string Phone { get; set; }
        string ClientType { get; set; }
    }
}
