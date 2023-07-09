namespace Z.RabbitMq.Base.RabbitMq.Config
{
    public class RabbitConstant
    {
        /// <summary>
        /// 支付交换机<see langword="pay.delay.exchange"/>
        /// </summary>
        public const string DELAY_EXCHANGE = "pay.delay.exchange";

        /// <summary>
        /// 支付routingkey<see langword="pay.delay.routing.key"/>
        /// </summary>
        public const string DELAY_ROUTING_KEY = "pay.delay.routing.key";

        /// <summary>
        /// 延迟队列<see langword="delay.queue"/>
        /// </summary>
        public const string DELAY_QUEUE = "delay.queue";

        /// <summary>
        /// 死信交换机<see langword="dead.letter.exchange"/>
        /// </summary>
        public const string DEAD_LETTER_EXCHANGE = "dead.letter.exchange";

        /// <summary>
        /// 死信队列 <see langword="dead.letter.queue"/>
        /// </summary>
        public const string DEAD_LETTER_QUEUE = "dead.letter.queue";

        /// <summary>
        /// 死信routingkey<see langword="dead.letter.routing.key"/>
        /// </summary>
        public const string DEAD_LETTER_ROUTING_KEY = "dead.letter.routing.key";

        /// <summary>
        /// 测试交换机<see langword="test.exchange"/>
        /// </summary>
        public const string TEST_EXCHANGE = "test.exchange";

        /// <summary>
        /// 测试队列<see langword="test.queue"/>
        /// </summary>
        public const string TEST_QUEUE = "test.queue";
    }
}