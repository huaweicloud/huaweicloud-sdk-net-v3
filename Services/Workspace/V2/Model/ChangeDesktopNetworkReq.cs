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
    /// 切换桌面网络请求体。
    /// </summary>
    public class ChangeDesktopNetworkReq 
    {

        /// <summary>
        /// 待切换VPC的ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 待切换子网的ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 指定私有IP地址。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 安全组ID列表。
        /// </summary>
        [JsonProperty("security_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroupIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeDesktopNetworkReq {\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  securityGroupIds: ").Append(SecurityGroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeDesktopNetworkReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeDesktopNetworkReq input)
        {
            if (input == null) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.PrivateIp != input.PrivateIp || (this.PrivateIp != null && !this.PrivateIp.Equals(input.PrivateIp))) return false;
            if (this.SecurityGroupIds != input.SecurityGroupIds || (this.SecurityGroupIds != null && input.SecurityGroupIds != null && !this.SecurityGroupIds.SequenceEqual(input.SecurityGroupIds))) return false;

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
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.PrivateIp != null) hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.SecurityGroupIds != null) hashCode = hashCode * 59 + this.SecurityGroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
