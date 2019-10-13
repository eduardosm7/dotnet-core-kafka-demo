using Confluent.Kafka;

namespace kafka_producer
{
    public interface IKafkaProducer
    {
        void Produce(string message, string topic);
    }
}