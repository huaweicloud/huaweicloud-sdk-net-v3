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
    /// Response Object
    /// </summary>
    public class ShowRocketMqConfigsResponse : SdkResponse
    {

        /// <summary>
        /// RocketMQ配置。
        /// </summary>
        [JsonProperty("rocketmq_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<RocketMQConfigResp> RocketmqConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRocketMqConfigsResponse {\n");
            sb.Append("  rocketmqConfigs: ").Append(RocketmqConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRocketMqConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRocketMqConfigsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RocketmqConfigs == input.RocketmqConfigs ||
                    this.RocketmqConfigs != null &&
                    input.RocketmqConfigs != null &&
                    this.RocketmqConfigs.SequenceEqual(input.RocketmqConfigs)
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
                if (this.RocketmqConfigs != null)
                    hashCode = hashCode * 59 + this.RocketmqConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
