using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Confluent.Kafka;
using Confluent.Kafka.Admin;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;

namespace KafkaDemoUI
{
    public class KafkaEngine
    {
        private string _properties { get; set; }
        private IConfiguration _configuration;
        private AdminClientConfig _adminClientConfig;

        public List<string> Topics { get; set; } = new List<string>();

        public KafkaEngine(string properties) 
        { 
            _properties= properties;
            _configuration = new ConfigurationBuilder()
                .AddIniFile(_properties)
                .Build();

            _adminClientConfig = new AdminClientConfig()
            {
                BootstrapServers = $"{_configuration["bootstrap.servers"]}",
                SaslPassword = _configuration[ "sasl.password" ],
                SaslUsername = _configuration["sasl.username"],
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.Plain,
                Debug = "all"
            };

            using (var adminClient = new AdminClientBuilder(_adminClientConfig)
                .SetLogHandler((_, m) => Console.WriteLine($"[{DateTime.Now}] [{m.Level}] {m.Message}"))
                .Build())
            {
                var metadata = adminClient.GetMetadata(TimeSpan.FromSeconds(10));
                var topicsMetadata = metadata.Topics;
                var topicNames = metadata.Topics.Select(a => a.Topic).ToList();

                foreach (var item in topicNames)
                {
                    Topics.Add(item);
                }

            }

        }

        public object ProduceMessage(string message, string topic)
        {
            object retObj = null;
            string key = Guid.NewGuid().ToString();

            using (var producer = new ProducerBuilder<string, string>(
                _configuration.AsEnumerable()).Build())
            {
                producer.Produce(topic, new Message<string, string> { Key = key, Value = message },
                   (deliveryReport) =>
                   {
                       if (deliveryReport.Error.Code != ErrorCode.NoError)
                       {

                           Console.WriteLine($"Failed to deliver message: {deliveryReport.Error.Reason}");
                       }

                       retObj = new object[]
                       {
                                key,
                                deliveryReport.Error.Code,
                                deliveryReport.Error.Reason
                       };
                   });
            }

            return retObj;
        }

        public bool ValidateTopic(string topic)
        {

            return true;
        }

    }
}
