using Z.RabbitMq.Entities;

namespace Z.RabbitMq.Base.RabbitMq.Message
{
    public class OrderMessage
    {
        public OrderInfo OrderInfo { get; set; }
        public Account Account { get; set; }
    }
}