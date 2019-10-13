using System;
using Confluent.Kafka;

namespace kafka_producer
{
    public class KafkaProducer : IKafkaProducer
    {
        private ProducerConfig config = new ProducerConfig { BootstrapServers = "kafka:9092" };

        public async void Produce(string message, string topic)
        {
            var msg = new Message<Null, string> { Value = message };

            using (var producerBuilder = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var deliveryResult = await producerBuilder.ProduceAsync(topic, msg);
                    Console.WriteLine($"Delivered '{deliveryResult.Value}' to '{deliveryResult.TopicPartitionOffset}'");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
    }
}