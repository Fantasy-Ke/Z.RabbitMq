using Z.RabbitMq.Entities;

namespace Z.RabbitMq.Service
{
    public interface IPayService
    {
        void UpdateOrderPayState(OrderInfo orderInfo);
    }
}