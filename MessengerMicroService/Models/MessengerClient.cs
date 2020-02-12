using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.Models
{
    public abstract class MessengerClient: IMessengerClient
    {
        private MessengerConfig _messengerConfig;
        
        public MessengerClient(MessengerConfig messengerConfig)
        {
            _messengerConfig = messengerConfig;
        }

        public bool SendMessage()
        {
            return true;
        }

        public bool GetAnswer()
        {
            return true;
        }
    }
}
