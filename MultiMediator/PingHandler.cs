using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace MultiMediator
{
    public class PingHandler1 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Ping1 Pong");
            Console.WriteLine("Ping1 Pong");
            return Task.CompletedTask;
        }
    }

    public class PingHandler2 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Ping2 Pong");
            Console.WriteLine("Ping2 Pong");
            return Task.CompletedTask;
        }
    }
}
