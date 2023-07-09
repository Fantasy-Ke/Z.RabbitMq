namespace Z.RabbitMq.Service
{
    public interface IOrderService
    {
        void SendOrderMessage();
        void SendTestMessage(string message);
    }
}