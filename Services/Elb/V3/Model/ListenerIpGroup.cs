using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// listener对象中的ipgroup信息
    /// </summary>
    public class ListenerIpGroup 
    {

        /// <summary>
        /// **参数解释**：监听器关联的访问控制组的ID。 关联多个IP地址组时ID使用逗号分隔。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("ipgroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpgroupId { get; set; }

        /// <summary>
        /// **参数解释**：访问控制组的状态。 开启访问控制的监听器，允许直接删除。  **取值范围**： - true:开启访问控制。 - false：关闭访问控制。
        /// </summary>
        [JsonProperty("enable_ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpgroup { get; set; }

        /// <summary>
        /// **参数解释**：访问控制组的类型。  **取值范围**： - white:白名单，只允许指定ip访问。 - black:黑名单，不允许指定ip访问。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListenerIpGroup {\n");
            sb.Append("  ipgroupId: ").Append(IpgroupId).Append("\n");
            sb.Append("  enableIpgroup: ").Append(EnableIpgroup).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListenerIpGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListenerIpGroup input)
        {
            if (input == null) return false;
            if (this.IpgroupId != input.IpgroupId || (this.IpgroupId != null && !this.IpgroupId.Equals(input.IpgroupId))) return false;
            if (this.EnableIpgroup != input.EnableIpgroup || (this.EnableIpgroup != null && !this.EnableIpgroup.Equals(input.EnableIpgroup))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.IpgroupId != null) hashCode = hashCode * 59 + this.IpgroupId.GetHashCode();
                if (this.EnableIpgroup != null) hashCode = hashCode * 59 + this.EnableIpgroup.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
