using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessengerMicroService.RabbitMQ
{
    public interface IRabbitManager
    {
        void Publish<T>(T message, string exchangeName, string exchangeType, string routeKey) where T : class;

        void Publish<T>(T message, string routeKey) where T : class;
    }
}
