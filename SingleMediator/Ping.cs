using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SingleMediator
{
    /// <summary>
    /// 构建消息请求
    /// </summary>
    public class Ping : IRequest<string>
    {
    }
}
