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
    public class ShowInstanceConfigsResponse : SdkResponse
    {

        /// <summary>
        /// kafka配置列表。
        /// </summary>
        [JsonProperty("kafka_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceConfig> KafkaConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceConfigsResponse {\n");
            sb.Append("  kafkaConfigs: ").Append(KafkaConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceConfigsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KafkaConfigs == input.KafkaConfigs ||
                    this.KafkaConfigs != null &&
                    input.KafkaConfigs != null &&
                    this.KafkaConfigs.SequenceEqual(input.KafkaConfigs)
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
                if (this.KafkaConfigs != null)
                    hashCode = hashCode * 59 + this.KafkaConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
