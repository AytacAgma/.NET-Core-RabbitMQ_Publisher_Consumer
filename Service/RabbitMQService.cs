using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RabbitMQService
    {
        private readonly string _hostName = "localhost";
        private readonly string _userName = "guest";
        private readonly string _password = "guest";

        public IConnection GetRabbitMQConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password
            };

            return connectionFactory.CreateConnection();
        }
    }
}
