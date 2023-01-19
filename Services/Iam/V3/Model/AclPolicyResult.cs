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
    public class AclPolicyResult 
    {

        /// <summary>
        /// 允许访问的IP地址或网段。
        /// </summary>
        [JsonProperty("allow_address_netmasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowAddressNetmasksResult> AllowAddressNetmasks { get; set; }

        /// <summary>
        /// 允许访问的IP地址区间。
        /// </summary>
        [JsonProperty("allow_ip_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<AllowIpRangesResult> AllowIpRanges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AclPolicyResult {\n");
            sb.Append("  allowAddressNetmasks: ").Append(AllowAddressNetmasks).Append("\n");
            sb.Append("  allowIpRanges: ").Append(AllowIpRanges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AclPolicyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AclPolicyResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowAddressNetmasks == input.AllowAddressNetmasks ||
                    this.AllowAddressNetmasks != null &&
                    input.AllowAddressNetmasks != null &&
                    this.AllowAddressNetmasks.SequenceEqual(input.AllowAddressNetmasks)
                ) && 
                (
                    this.AllowIpRanges == input.AllowIpRanges ||
                    this.AllowIpRanges != null &&
                    input.AllowIpRanges != null &&
                    this.AllowIpRanges.SequenceEqual(input.AllowIpRanges)
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
                if (this.AllowAddressNetmasks != null)
                    hashCode = hashCode * 59 + this.AllowAddressNetmasks.GetHashCode();
                if (this.AllowIpRanges != null)
                    hashCode = hashCode * 59 + this.AllowIpRanges.GetHashCode();
                return hashCode;
            }
        }
    }
}
