using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaDemoUI
{
    public class KafkaProducer
    {
        public delegate void NotifyMessageProduced();

        public event NotifyMessageProduced MessageProduced;

        protected virtual void OnMessageProduced()
        {

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


    }
}
