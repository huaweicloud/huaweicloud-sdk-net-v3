using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceNetwork 
    {

        /// <summary>
        /// **参数解释：** kubernetes clusterIP IPv4 CIDR取值范围。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 默认为\&quot;10.247.0.0/16\&quot;。 
        /// </summary>
        [JsonProperty("IPv4CIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string IPv4CIDR { get; set; }

        /// <summary>
        /// **参数解释：** kubernetes clusterIP IPv6 CIDR取值范围。 **约束限制：** 仅开启IPV6双栈的Turbo集群支持配置IPv6服务网段。 **取值范围：** 不涉及 **默认取值：** Turbo集群默认为\&quot;fc00::/112\&quot; CCE集群默认为\&quot;fd00:1234::/120\&quot; 
        /// </summary>
        [JsonProperty("IPv6CIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string IPv6CIDR { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceNetwork {\n");
            sb.Append("  iPv4CIDR: ").Append(IPv4CIDR).Append("\n");
            sb.Append("  iPv6CIDR: ").Append(IPv6CIDR).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceNetwork input)
        {
            if (input == null) return false;
            if (this.IPv4CIDR != input.IPv4CIDR || (this.IPv4CIDR != null && !this.IPv4CIDR.Equals(input.IPv4CIDR))) return false;
            if (this.IPv6CIDR != input.IPv6CIDR || (this.IPv6CIDR != null && !this.IPv6CIDR.Equals(input.IPv6CIDR))) return false;

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
                if (this.IPv4CIDR != null) hashCode = hashCode * 59 + this.IPv4CIDR.GetHashCode();
                if (this.IPv6CIDR != null) hashCode = hashCode * 59 + this.IPv6CIDR.GetHashCode();
                return hashCode;
            }
        }
    }
}
