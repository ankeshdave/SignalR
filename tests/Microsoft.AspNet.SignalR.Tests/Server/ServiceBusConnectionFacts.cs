using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.ServiceBus;
using Xunit;
using Xunit.Extensions;

namespace Microsoft.AspNet.SignalR.Tests.Server
{
    public class ServiceBusConnectionFacts
    {
        [Fact]
        public void ConstructorDoesNotThrowWithInvalidConnectionString()
        {
            var config = new ServiceBusScaleoutConfiguration("connection","topic");
            Assert.DoesNotThrow(() => new ServiceBusConnection(config, new TraceSource("trace")));
        }

    }
}
