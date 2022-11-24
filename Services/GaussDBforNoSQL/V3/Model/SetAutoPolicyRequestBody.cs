using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetAutoPolicyRequestBody 
    {

        /// <summary>
        /// 设置磁盘自动扩容的实例组ID。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 自动扩容开关。  “on”，表示开启磁盘自动扩容策略。  “off”，表示关闭磁盘自动扩容策略。 默认值为“on”。
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchOption { get; set; }

        /// <summary>
        /// 磁盘自动扩容策略
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiskAutoExpansionPolicy> Policy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetAutoPolicyRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetAutoPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetAutoPolicyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceIds == input.InstanceIds ||
                    this.InstanceIds != null &&
                    input.InstanceIds != null &&
                    this.InstanceIds.SequenceEqual(input.InstanceIds)
                ) && 
                (
                    this.SwitchOption == input.SwitchOption ||
                    (this.SwitchOption != null &&
                    this.SwitchOption.Equals(input.SwitchOption))
                ) && 
                (
                    this.Policy == input.Policy ||
                    this.Policy != null &&
                    input.Policy != null &&
                    this.Policy.SequenceEqual(input.Policy)
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
                if (this.InstanceIds != null)
                    hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.SwitchOption != null)
                    hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }
    }
}
