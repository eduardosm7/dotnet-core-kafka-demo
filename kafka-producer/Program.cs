using System;
using System.Threading;

namespace kafka_producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new KafkaProducer();

            var counter = 0;

            while (true)
            {
                producer.Produce($"data {counter}", "test-topic");
                counter++;
                Thread.Sleep(1000);
            }
        }
    }
}
