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
    public class ModifyConfigReq 
    {

        /// <summary>
        /// RocketMQ配置。
        /// </summary>
        [JsonProperty("rocketmq_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<RocketMQConfigReq> RocketmqConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyConfigReq {\n");
            sb.Append("  rocketmqConfigs: ").Append(RocketmqConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyConfigReq input)
        {
            if (input == null) return false;
            if (this.RocketmqConfigs != input.RocketmqConfigs || (this.RocketmqConfigs != null && input.RocketmqConfigs != null && !this.RocketmqConfigs.SequenceEqual(input.RocketmqConfigs))) return false;

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
                if (this.RocketmqConfigs != null) hashCode = hashCode * 59 + this.RocketmqConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
