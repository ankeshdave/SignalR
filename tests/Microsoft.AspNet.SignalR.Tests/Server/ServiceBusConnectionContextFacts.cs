using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.ServiceBus;
using Xunit;
using Microsoft.ServiceBus.Messaging;

namespace Microsoft.AspNet.SignalR.Tests.Server
{
    public class ServiceBusConnectionContextFacts
    {
        [Fact]
        void DisposeDoesNotThrowWithNullTopic()
        {
            var connectionContext = new ServiceBusConnectionContext(new ServiceBusScaleoutConfiguration("connection", "topics"), null, null, (int x, IEnumerable<BrokeredMessage> msg) => { }, (int x, Exception ex) => { }, (int x) => { });
            connectionContext.Dispose();
        }
    }
}
