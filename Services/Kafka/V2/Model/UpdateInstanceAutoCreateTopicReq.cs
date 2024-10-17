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
    public class UpdateInstanceAutoCreateTopicReq 
    {

        /// <summary>
        /// 是否开启自动创建topic功能。
        /// </summary>
        [JsonProperty("enable_auto_topic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoTopic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceAutoCreateTopicReq {\n");
            sb.Append("  enableAutoTopic: ").Append(EnableAutoTopic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceAutoCreateTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceAutoCreateTopicReq input)
        {
            if (input == null) return false;
            if (this.EnableAutoTopic != input.EnableAutoTopic || (this.EnableAutoTopic != null && !this.EnableAutoTopic.Equals(input.EnableAutoTopic))) return false;

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
                if (this.EnableAutoTopic != null) hashCode = hashCode * 59 + this.EnableAutoTopic.GetHashCode();
                return hashCode;
            }
        }
    }
}
