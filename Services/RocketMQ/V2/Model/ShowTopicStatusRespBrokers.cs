using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowTopicStatusRespBrokers 
    {

        /// <summary>
        /// 队列列表。
        /// </summary>
        [JsonProperty("queues", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowTopicStatusRespQueues> Queues { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopicStatusRespBrokers {\n");
            sb.Append("  queues: ").Append(Queues).Append("\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopicStatusRespBrokers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopicStatusRespBrokers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Queues == input.Queues ||
                    this.Queues != null &&
                    input.Queues != null &&
                    this.Queues.SequenceEqual(input.Queues)
                ) && 
                (
                    this.BrokerName == input.BrokerName ||
                    (this.BrokerName != null &&
                    this.BrokerName.Equals(input.BrokerName))
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
                if (this.Queues != null)
                    hashCode = hashCode * 59 + this.Queues.GetHashCode();
                if (this.BrokerName != null)
                    hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
