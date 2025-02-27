using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsoleAclPolicyOption 
    {

        /// <summary>
        /// 允许访问的IP地址或网段。
        /// </summary>
        [JsonProperty("allow_address_netmasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowAddressNetmasksOption> AllowAddressNetmasks { get; set; }

        /// <summary>
        /// 允许访问的IP地址区间。
        /// </summary>
        [JsonProperty("allow_ip_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowIpRangesOption> AllowIpRanges { get; set; }

        /// <summary>
        /// 允许访问的IPv6地址或网段。
        /// </summary>
        [JsonProperty("allow_address_netmasks_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowAddressNetmasksOptionIPv6> AllowAddressNetmasksIpv6 { get; set; }

        /// <summary>
        /// 允许访问的IPv6地址区间。
        /// </summary>
        [JsonProperty("allow_ip_ranges_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowIpRangesOptionIPv6> AllowIpRangesIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsoleAclPolicyOption {\n");
            sb.Append("  allowAddressNetmasks: ").Append(AllowAddressNetmasks).Append("\n");
            sb.Append("  allowIpRanges: ").Append(AllowIpRanges).Append("\n");
            sb.Append("  allowAddressNetmasksIpv6: ").Append(AllowAddressNetmasksIpv6).Append("\n");
            sb.Append("  allowIpRangesIpv6: ").Append(AllowIpRangesIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsoleAclPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsoleAclPolicyOption input)
        {
            if (input == null) return false;
            if (this.AllowAddressNetmasks != input.AllowAddressNetmasks || (this.AllowAddressNetmasks != null && input.AllowAddressNetmasks != null && !this.AllowAddressNetmasks.SequenceEqual(input.AllowAddressNetmasks))) return false;
            if (this.AllowIpRanges != input.AllowIpRanges || (this.AllowIpRanges != null && input.AllowIpRanges != null && !this.AllowIpRanges.SequenceEqual(input.AllowIpRanges))) return false;
            if (this.AllowAddressNetmasksIpv6 != input.AllowAddressNetmasksIpv6 || (this.AllowAddressNetmasksIpv6 != null && input.AllowAddressNetmasksIpv6 != null && !this.AllowAddressNetmasksIpv6.SequenceEqual(input.AllowAddressNetmasksIpv6))) return false;
            if (this.AllowIpRangesIpv6 != input.AllowIpRangesIpv6 || (this.AllowIpRangesIpv6 != null && input.AllowIpRangesIpv6 != null && !this.AllowIpRangesIpv6.SequenceEqual(input.AllowIpRangesIpv6))) return false;

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
                if (this.AllowAddressNetmasks != null) hashCode = hashCode * 59 + this.AllowAddressNetmasks.GetHashCode();
                if (this.AllowIpRanges != null) hashCode = hashCode * 59 + this.AllowIpRanges.GetHashCode();
                if (this.AllowAddressNetmasksIpv6 != null) hashCode = hashCode * 59 + this.AllowAddressNetmasksIpv6.GetHashCode();
                if (this.AllowIpRangesIpv6 != null) hashCode = hashCode * 59 + this.AllowIpRangesIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
