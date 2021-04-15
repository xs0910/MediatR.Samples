using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace SingleMediator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            // 注册MediatR服务
            services.AddMediatR(typeof(Program).Assembly);

            var servicesProvider = services.BuildServiceProvider();

            // 从容器中获取IMediator
            var mediator = servicesProvider.GetService<IMediator>();

            // 发送消息，并返回响应
            var send = await mediator.Send(new Ping());

            Console.WriteLine(send);

            Console.ReadKey();
        }
    }
}
