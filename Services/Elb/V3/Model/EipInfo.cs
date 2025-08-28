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
    /// **参数解释**：弹性IP，同publicips。
    /// </summary>
    public class EipInfo 
    {

        /// <summary>
        /// **参数解释**：弹性IP的ID。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EipId { get; set; }

        /// <summary>
        /// **参数解释**：弹性IP的IP地址。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("eip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EipAddress { get; set; }

        /// <summary>
        /// **参数解释**：IP版本号。  **取值范围**： - 4：表示IPv4地址。 - 6：表示IPv6地址。  [不支持IPv6，请勿设置为6。](tag:dt)
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipInfo {\n");
            sb.Append("  eipId: ").Append(EipId).Append("\n");
            sb.Append("  eipAddress: ").Append(EipAddress).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipInfo input)
        {
            if (input == null) return false;
            if (this.EipId != input.EipId || (this.EipId != null && !this.EipId.Equals(input.EipId))) return false;
            if (this.EipAddress != input.EipAddress || (this.EipAddress != null && !this.EipAddress.Equals(input.EipAddress))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;

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
                if (this.EipId != null) hashCode = hashCode * 59 + this.EipId.GetHashCode();
                if (this.EipAddress != null) hashCode = hashCode * 59 + this.EipAddress.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
