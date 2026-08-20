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
    /// Topic流控配置
    /// </summary>
    public class KafkaTopicQuota 
    {

        /// <summary>
        /// Topic名称
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 生产者速率
        /// </summary>
        [JsonProperty("producer_byte_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducerByteRate { get; set; }

        /// <summary>
        /// 消费者速率
        /// </summary>
        [JsonProperty("consumer_byte_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumerByteRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaTopicQuota {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  producerByteRate: ").Append(ProducerByteRate).Append("\n");
            sb.Append("  consumerByteRate: ").Append(ConsumerByteRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaTopicQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaTopicQuota input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.ProducerByteRate != input.ProducerByteRate || (this.ProducerByteRate != null && !this.ProducerByteRate.Equals(input.ProducerByteRate))) return false;
            if (this.ConsumerByteRate != input.ConsumerByteRate || (this.ConsumerByteRate != null && !this.ConsumerByteRate.Equals(input.ConsumerByteRate))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.ProducerByteRate != null) hashCode = hashCode * 59 + this.ProducerByteRate.GetHashCode();
                if (this.ConsumerByteRate != null) hashCode = hashCode * 59 + this.ConsumerByteRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
