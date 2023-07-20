using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KafkaTopicProducerResponseProducers 
    {

        /// <summary>
        /// 生产者地址
        /// </summary>
        [JsonProperty("producer_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ProducerAddress { get; set; }

        /// <summary>
        /// broker地址
        /// </summary>
        [JsonProperty("broker_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerAddress { get; set; }

        /// <summary>
        /// 加入时间
        /// </summary>
        [JsonProperty("join_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? JoinTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaTopicProducerResponseProducers {\n");
            sb.Append("  producerAddress: ").Append(ProducerAddress).Append("\n");
            sb.Append("  brokerAddress: ").Append(BrokerAddress).Append("\n");
            sb.Append("  joinTime: ").Append(JoinTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaTopicProducerResponseProducers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaTopicProducerResponseProducers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProducerAddress == input.ProducerAddress ||
                    (this.ProducerAddress != null &&
                    this.ProducerAddress.Equals(input.ProducerAddress))
                ) && 
                (
                    this.BrokerAddress == input.BrokerAddress ||
                    (this.BrokerAddress != null &&
                    this.BrokerAddress.Equals(input.BrokerAddress))
                ) && 
                (
                    this.JoinTime == input.JoinTime ||
                    (this.JoinTime != null &&
                    this.JoinTime.Equals(input.JoinTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProducerAddress != null)
                    hashCode = hashCode * 59 + this.ProducerAddress.GetHashCode();
                if (this.BrokerAddress != null)
                    hashCode = hashCode * 59 + this.BrokerAddress.GetHashCode();
                if (this.JoinTime != null)
                    hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
