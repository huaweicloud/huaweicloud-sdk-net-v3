using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FixedIp 
    {

        /// <summary>
        /// 功能说明：端口IP地址,如果同时指定子网ID和IP地址，会尝试将该子网上的IP地址分配给该端口。 如果仅指定子网ID，会将该子网中的可用IP分配给该端口。 如果仅指定IP地址，会尝试分配IP地址（如果该地址是指定网络上任何子网的有效IP）
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 功能说明：端口所属子网ID,如果同时指定子网ID和IP地址，会尝试将该子网上的IP地址分配给该端口。 如果仅指定子网ID，会将该子网中的可用IP分配给该端口。 如果仅指定IP地址，会尝试分配IP地址（如果该地址是指定网络上任何子网的有效IP）
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedIp {\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FixedIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FixedIp input)
        {
            if (input == null) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;

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
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
