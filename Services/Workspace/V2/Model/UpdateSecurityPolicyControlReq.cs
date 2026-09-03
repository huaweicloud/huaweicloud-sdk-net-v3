using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Update security policy control request.
    /// </summary>
    public class UpdateSecurityPolicyControlReq 
    {

        /// <summary>
        /// 需要开启安全策略管控的实例 ID 列表。
        /// </summary>
        [JsonProperty("enabled_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnabledInstances { get; set; }

        /// <summary>
        /// 需要开启安全策略管控的标签列表，格式为 key:value。
        /// </summary>
        [JsonProperty("enabled_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnabledTags { get; set; }

        /// <summary>
        /// 需要关闭安全策略管控的实例 ID 列表。
        /// </summary>
        [JsonProperty("disabled_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DisabledInstances { get; set; }

        /// <summary>
        /// 需要关闭安全策略管控的标签列表，格式为 key:value。
        /// </summary>
        [JsonProperty("disabled_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DisabledTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecurityPolicyControlReq {\n");
            sb.Append("  enabledInstances: ").Append(EnabledInstances).Append("\n");
            sb.Append("  enabledTags: ").Append(EnabledTags).Append("\n");
            sb.Append("  disabledInstances: ").Append(DisabledInstances).Append("\n");
            sb.Append("  disabledTags: ").Append(DisabledTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecurityPolicyControlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecurityPolicyControlReq input)
        {
            if (input == null) return false;
            if (this.EnabledInstances != input.EnabledInstances || (this.EnabledInstances != null && input.EnabledInstances != null && !this.EnabledInstances.SequenceEqual(input.EnabledInstances))) return false;
            if (this.EnabledTags != input.EnabledTags || (this.EnabledTags != null && input.EnabledTags != null && !this.EnabledTags.SequenceEqual(input.EnabledTags))) return false;
            if (this.DisabledInstances != input.DisabledInstances || (this.DisabledInstances != null && input.DisabledInstances != null && !this.DisabledInstances.SequenceEqual(input.DisabledInstances))) return false;
            if (this.DisabledTags != input.DisabledTags || (this.DisabledTags != null && input.DisabledTags != null && !this.DisabledTags.SequenceEqual(input.DisabledTags))) return false;

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
                if (this.EnabledInstances != null) hashCode = hashCode * 59 + this.EnabledInstances.GetHashCode();
                if (this.EnabledTags != null) hashCode = hashCode * 59 + this.EnabledTags.GetHashCode();
                if (this.DisabledInstances != null) hashCode = hashCode * 59 + this.DisabledInstances.GetHashCode();
                if (this.DisabledTags != null) hashCode = hashCode * 59 + this.DisabledTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
