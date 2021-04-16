using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace MultiMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            // 注册MediatR服务
            services.AddMediatR(typeof(Program).Assembly);

            var serviceProvider = services.BuildServiceProvider();

            IMediator mediator = serviceProvider.GetService<IMediator>();

            // 发布消息
            mediator.Publish(new Ping());

            Console.Read();
        }
    }
}
