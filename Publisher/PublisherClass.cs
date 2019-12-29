using RabbitMQ.Client;
using Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Publisher
{
    public class PublisherClass
    {
        private readonly RabbitMQService _rabbitMQService;

        public PublisherClass(string queueName, string message)
        {
            _rabbitMQService = new RabbitMQService();

            using (var connection = _rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queueName, false, false, false, null);

                    channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

                    Console.WriteLine("{0} queue'su üzerine, \"{1}\" mesajı yazıldı.", queueName, message);
                }
            }
        }
    }
}
