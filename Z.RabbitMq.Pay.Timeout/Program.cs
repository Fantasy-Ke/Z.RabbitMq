using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

using System;
using Z.RabbitMq.Base.RabbitMq.Config;
using Z.RabbitMq.Base.RabbitMq.Producer;
using Z.RabbitMq.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Z.RabbitMq.Pay.Timeout
{
    class Program
    {
        static void Main(string[] args)
        {
            var configRabbit = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("RabbitMQ");

            var host = new HostBuilder()
                .ConfigureServices(collection => collection
                    .AddSingleton(new RabbitConnection(configRabbit.Get<RabbitOption>()))
                    .AddSingleton<IHostedService, ProcessPayTimeout>()
                    .AddScoped<IRabbitProducer, RabbitProducer>()
                    .AddScoped<IPayService, PayService>())
                .Build();
            host.Run();
        }
    }
}
