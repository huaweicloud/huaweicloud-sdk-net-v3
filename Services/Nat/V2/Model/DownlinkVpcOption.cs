using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 私网NAT网关实例所属的VPC实例。
    /// </summary>
    public class DownlinkVpcOption 
    {

        /// <summary>
        /// 私网NAT网关实例所属的子网的ID。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        /// <summary>
        /// 私网NAT网关的ngport_ip_addrss。
        /// </summary>
        [JsonProperty("ngport_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string NgportIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownlinkVpcOption {\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  ngportIpAddress: ").Append(NgportIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownlinkVpcOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownlinkVpcOption input)
        {
            if (input == null) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && !this.VirsubnetId.Equals(input.VirsubnetId))) return false;
            if (this.NgportIpAddress != input.NgportIpAddress || (this.NgportIpAddress != null && !this.NgportIpAddress.Equals(input.NgportIpAddress))) return false;

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
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.NgportIpAddress != null) hashCode = hashCode * 59 + this.NgportIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
