using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BareMetalModifyPortRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reverse_binding", NullValueHandling = NullValueHandling.Ignore)]
        public List<bool?> ReverseBinding { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BareMetalModifyPortRequest {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  ipAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  reverseBinding: ").Append(ReverseBinding).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BareMetalModifyPortRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BareMetalModifyPortRequest input)
        {
            if (input == null) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.DeviceOwner != input.DeviceOwner || (this.DeviceOwner != null && !this.DeviceOwner.Equals(input.DeviceOwner))) return false;
            if (this.IpAddresses != input.IpAddresses || (this.IpAddresses != null && input.IpAddresses != null && !this.IpAddresses.SequenceEqual(input.IpAddresses))) return false;
            if (this.ReverseBinding != input.ReverseBinding || (this.ReverseBinding != null && input.ReverseBinding != null && !this.ReverseBinding.SequenceEqual(input.ReverseBinding))) return false;

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
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.DeviceOwner != null) hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.IpAddresses != null) hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                if (this.ReverseBinding != null) hashCode = hashCode * 59 + this.ReverseBinding.GetHashCode();
                return hashCode;
            }
        }
    }
}
