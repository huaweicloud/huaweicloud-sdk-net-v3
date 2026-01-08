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
    public class PortExtraDhcpOpt 
    {

        /// <summary>
        /// **参数解释**： DHCP属性名称。在DHCP服务器为客户端分配IP地址时，传递的额外的控制信息或网络配置参数的名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("opt_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OptName { get; set; }

        /// <summary>
        /// **参数解释**： DHCP属性值。在DHCP服务器为客户端分配IP地址时，传递的额外的控制信息或网络配置参数的值。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("opt_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OptValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortExtraDhcpOpt {\n");
            sb.Append("  optName: ").Append(OptName).Append("\n");
            sb.Append("  optValue: ").Append(OptValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortExtraDhcpOpt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortExtraDhcpOpt input)
        {
            if (input == null) return false;
            if (this.OptName != input.OptName || (this.OptName != null && !this.OptName.Equals(input.OptName))) return false;
            if (this.OptValue != input.OptValue || (this.OptValue != null && !this.OptValue.Equals(input.OptValue))) return false;

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
                if (this.OptName != null) hashCode = hashCode * 59 + this.OptName.GetHashCode();
                if (this.OptValue != null) hashCode = hashCode * 59 + this.OptValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
