﻿using Z.RabbitMq.Base.RabbitMq.Config;
using Z.RabbitMq.Base.RabbitMq.Producer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Z.RabbitMq.Test
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
                    .AddSingleton<IHostedService, ProcessTest>()
                    .AddScoped<IRabbitProducer, RabbitProducer>())
                    .Build();
            host.Run();
        }
    }
}
