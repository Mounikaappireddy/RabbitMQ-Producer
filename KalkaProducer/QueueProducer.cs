using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace KalkaProducer
{
   public static class QueueProducer
    {
        public static void Publish(IModel channel)
        {
            channel.QueueDeclare("batch22.queuel",
                durable:true,
                exclusive: false,
                autoDelete: false,
                arguments: null);
            var count = 10;
            var message = new
            {
                Name = "Producer", Message = $"from Producer:{count } "
            };
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
            channel.BasicPublish("", "batch22.queuel", null, body);
        }
    }
}
