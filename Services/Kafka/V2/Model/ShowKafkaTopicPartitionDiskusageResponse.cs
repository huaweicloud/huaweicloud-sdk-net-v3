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
    /// Response Object
    /// </summary>
    public class ShowKafkaTopicPartitionDiskusageResponse : SdkResponse
    {

        /// <summary>
        /// Broker列表。
        /// </summary>
        [JsonProperty("broker_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowKafkaTopicPartitionDiskusageRespBrokerList> BrokerList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKafkaTopicPartitionDiskusageResponse {\n");
            sb.Append("  brokerList: ").Append(BrokerList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKafkaTopicPartitionDiskusageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKafkaTopicPartitionDiskusageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrokerList == input.BrokerList ||
                    this.BrokerList != null &&
                    input.BrokerList != null &&
                    this.BrokerList.SequenceEqual(input.BrokerList)
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
                if (this.BrokerList != null)
                    hashCode = hashCode * 59 + this.BrokerList.GetHashCode();
                return hashCode;
            }
        }
    }
}
