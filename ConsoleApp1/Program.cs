using Consumer;
using Publisher;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string _queueName = "aytacagma";
        private static PublisherClass _publisher;
        private static ConsumerClass _consumer;

        static void Main(string[] args)
        {
            _publisher = new PublisherClass(_queueName, "RabbitMQ RabbitMQ");

            _consumer = new ConsumerClass(_queueName);

            Console.ReadKey();
        }
    }
}
