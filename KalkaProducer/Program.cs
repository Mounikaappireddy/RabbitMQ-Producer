using RabbitMQ.Client;
using System;

namespace KalkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            var connection = Factory.CreateConnection();
            var channel = connection.CreateModel();
            QueueProducer.Publish(channel);
    } }
}
