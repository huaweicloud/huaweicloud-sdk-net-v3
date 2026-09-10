using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachSubNetworkInterfaceOption 
    {

        /// <summary>
        /// **参数解释**： 辅助弹性网卡所挂载的弹性网卡的ID。 **取值范围**： 带“-”的标准UUID格式。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡关联的安全组的ID列表。例如：\&quot;security_groups\&quot;: [\&quot;a0608cbf-d047-4f54-8b28-cd7b59853fff\&quot;]。 **取值范围**： 如果请求时不指定此参数，辅助弹性网卡创建后会自动关联默认安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 辅助弹性网卡安全使能标记，如果不使能则安全组不生效。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecurityEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachSubNetworkInterfaceOption {\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  securityEnabled: ").Append(SecurityEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachSubNetworkInterfaceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachSubNetworkInterfaceOption input)
        {
            if (input == null) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.SecurityEnabled != input.SecurityEnabled || (this.SecurityEnabled != null && !this.SecurityEnabled.Equals(input.SecurityEnabled))) return false;

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
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.SecurityEnabled != null) hashCode = hashCode * 59 + this.SecurityEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
