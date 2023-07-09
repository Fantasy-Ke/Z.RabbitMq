﻿using System;
using System.Collections.Generic;
using Z.RabbitMq.Base.RabbitMq.Config;
using Z.RabbitMq.Base.RabbitMq.Message;
using Z.RabbitMq.Base.RabbitMq.Producer;
using Z.RabbitMq.Entities;
using Newtonsoft.Json;

namespace Z.RabbitMq.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRabbitProducer _rabbitProducer;

        public OrderService(IRabbitProducer rabbitProducer)
        {
            _rabbitProducer = rabbitProducer;
        }
        public void SendOrderMessage()
        {
            OrderInfo orderInfo = new OrderInfo();
            orderInfo.GoodsCount = 1;
            orderInfo.GoodsId = 1;
            orderInfo.GoodsName = "CodeMan老师rabbitmq教程";
            orderInfo.Status = 0;
            orderInfo.UserId = 1;
            Account account = new Account();
            account.Username = "Z.RabbitMQ";
            account.Password = "0210";
            account.Email = "zhoulucky210@163.com";
            account.Phone = "13999999999";
            OrderMessage orderMessage = new OrderMessage();
            orderMessage.Account = account;
            orderMessage.OrderInfo = orderInfo;
            Console.WriteLine("短信/邮件异步通知");
            Console.WriteLine($"send message:{JsonConvert.SerializeObject(orderMessage)}");
            // 支付服务
            _rabbitProducer.Publish(RabbitConstant.DELAY_EXCHANGE, RabbitConstant.DELAY_ROUTING_KEY, 
                new Dictionary<string, object>()
                {
                    {"x-delay", 1000 * 20}
                }, JsonConvert.SerializeObject(orderMessage));
        }

        public void SendTestMessage(string message)
        {
            Console.WriteLine($"send message:{message}");
            _rabbitProducer.Publish(RabbitConstant.TEST_EXCHANGE, "", new Dictionary<string, object>(), message);
        }
    }
}
