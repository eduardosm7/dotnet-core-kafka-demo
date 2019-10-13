namespace kafka_consumer
{
    public interface IKafkaConsumer
    {
        void Consume(string topic);
    }

}