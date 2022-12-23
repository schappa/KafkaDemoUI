using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaDemoUI
{
    public class KafkaAdmin
    {
        private string _properties { get; set; }
        private IConfiguration _configuration;
        private AdminClientConfig _adminClientConfig;
        public List<string> Topics { get; set; } = new List<string>();
        public IAdminClient AdminClient { get; set; }

        public KafkaAdmin(string properties) 
        {
            _properties = properties;
            _configuration = new ConfigurationBuilder()
                .AddIniFile(_properties)
                .Build();

            _adminClientConfig = new AdminClientConfig()
            {
                BootstrapServers = $"{_configuration["bootstrap.servers"]}",
                SaslPassword = _configuration["sasl.password"],
                SaslUsername = _configuration["sasl.username"],
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslMechanism = SaslMechanism.Plain,
                Debug = "all"
            };

            AdminClient = new AdminClientBuilder(_adminClientConfig).Build();

            var metadata = AdminClient.GetMetadata(TimeSpan.FromSeconds(10));
            var topicsMetadata = metadata.Topics;
            var topicNames = metadata.Topics.Select(a => a.Topic).ToList();

            foreach (var item in topicNames)
                Topics.Add(item);
        }
    }
}
