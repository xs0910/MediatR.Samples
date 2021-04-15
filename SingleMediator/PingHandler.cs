using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
namespace SingleMediator
{
    /// <summary>
    /// 构建消息处理
    /// </summary>
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult<string>("Response Pong");
        }
    }
}
