using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面网络信息：vpc、子网、私有ip、弹性ip、安全组
    /// </summary>
    public class NetworkInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public Vpc VpcInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subnet_info", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopSubnet SubnetInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("port_info", NullValueHandling = NullValueHandling.Ignore)]
        public Port PortInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public_ip_info", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIp PublicIpInfo { get; set; }

        /// <summary>
        /// 桌面绑定的安全组列表
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkInfo {\n");
            sb.Append("  vpcInfo: ").Append(VpcInfo).Append("\n");
            sb.Append("  subnetInfo: ").Append(SubnetInfo).Append("\n");
            sb.Append("  portInfo: ").Append(PortInfo).Append("\n");
            sb.Append("  publicIpInfo: ").Append(PublicIpInfo).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkInfo input)
        {
            if (input == null) return false;
            if (this.VpcInfo != input.VpcInfo || (this.VpcInfo != null && !this.VpcInfo.Equals(input.VpcInfo))) return false;
            if (this.SubnetInfo != input.SubnetInfo || (this.SubnetInfo != null && !this.SubnetInfo.Equals(input.SubnetInfo))) return false;
            if (this.PortInfo != input.PortInfo || (this.PortInfo != null && !this.PortInfo.Equals(input.PortInfo))) return false;
            if (this.PublicIpInfo != input.PublicIpInfo || (this.PublicIpInfo != null && !this.PublicIpInfo.Equals(input.PublicIpInfo))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;

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
                if (this.VpcInfo != null) hashCode = hashCode * 59 + this.VpcInfo.GetHashCode();
                if (this.SubnetInfo != null) hashCode = hashCode * 59 + this.SubnetInfo.GetHashCode();
                if (this.PortInfo != null) hashCode = hashCode * 59 + this.PortInfo.GetHashCode();
                if (this.PublicIpInfo != null) hashCode = hashCode * 59 + this.PublicIpInfo.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
