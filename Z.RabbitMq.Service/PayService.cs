using System;
using Z.RabbitMq.Entities;

namespace Z.RabbitMq.Service
{
    public class PayService : IPayService
    {
        public void UpdateOrderPayState(OrderInfo orderInfo)
        {
            Console.WriteLine($"修改订单状态:{orderInfo.Status}");
        }
    }
}