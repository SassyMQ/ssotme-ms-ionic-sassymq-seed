

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.MessagePatterns;
using SassyMQ.Lib.RabbitMQ;
using SassyMQ.MSSMQS.Lib.RabbitMQ;
using SassyMQ.Lib.RabbitMQ.Payload;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SassyMQ.MSSMQS.Lib.RMQActors;

namespace SassyMQ.MSSMQS.Lib
{
    public abstract class MSSMQSActorBase : SMQActorBase<MSSMQSPayload>
    {
        public MSSMQSActorBase(string allExchange, bool isAutoConnect) : base(allExchange, isAutoConnect)
        {
        }
    }
}