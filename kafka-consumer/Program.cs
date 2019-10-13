namespace kafka_consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = new KafkaConsumer();

            consumer.Consume("test-topic");
        }
    }
}
