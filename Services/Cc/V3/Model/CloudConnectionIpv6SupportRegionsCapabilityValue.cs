using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CloudConnectionIpv6SupportRegionsCapabilityValue 
    {

        /// <summary>
        /// 租户支持的区域列表。
        /// </summary>
        [JsonProperty("support_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportRegions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnectionIpv6SupportRegionsCapabilityValue {\n");
            sb.Append("  supportRegions: ").Append(SupportRegions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnectionIpv6SupportRegionsCapabilityValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnectionIpv6SupportRegionsCapabilityValue input)
        {
            if (input == null) return false;
            if (this.SupportRegions != input.SupportRegions || (this.SupportRegions != null && input.SupportRegions != null && !this.SupportRegions.SequenceEqual(input.SupportRegions))) return false;

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
                if (this.SupportRegions != null) hashCode = hashCode * 59 + this.SupportRegions.GetHashCode();
                return hashCode;
            }
        }
    }
}
