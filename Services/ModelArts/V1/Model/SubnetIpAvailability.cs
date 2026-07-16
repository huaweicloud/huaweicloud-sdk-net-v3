using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 子网可用的IP信息。
    /// </summary>
    public class SubnetIpAvailability 
    {

        /// <summary>
        /// **参数解释**：子网的cidr。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// **参数解释**：网络版本。 **取值范围**：可选值如下： - 4：代表ipV4
        /// </summary>
        [JsonProperty("ipVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// **参数解释**：已使用的IP数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("usedIps", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedIps { get; set; }

        /// <summary>
        /// **参数解释**：子网中总的IP数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("totalIps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubnetIpAvailability {\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  usedIps: ").Append(UsedIps).Append("\n");
            sb.Append("  totalIps: ").Append(TotalIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubnetIpAvailability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubnetIpAvailability input)
        {
            if (input == null) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.UsedIps != input.UsedIps || (this.UsedIps != null && !this.UsedIps.Equals(input.UsedIps))) return false;
            if (this.TotalIps != input.TotalIps || (this.TotalIps != null && !this.TotalIps.Equals(input.TotalIps))) return false;

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
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.UsedIps != null) hashCode = hashCode * 59 + this.UsedIps.GetHashCode();
                if (this.TotalIps != null) hashCode = hashCode * 59 + this.TotalIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
