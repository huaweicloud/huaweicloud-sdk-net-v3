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
    /// 网络信息
    /// </summary>
    public class NetworkConfig 
    {

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// VPC名称
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 业务子网，可以指定返回的网络ID订购桌面
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 后端管理组件占用的子网网段
        /// </summary>
        [JsonProperty("management_subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementSubnetCidr { get; set; }

        /// <summary>
        /// subnet_ids所返回的业务子网中,被管理节点所占用的子网id
        /// </summary>
        [JsonProperty("management_node_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementNodeSubnetId { get; set; }

        /// <summary>
        /// VPC配置信息列表。
        /// </summary>
        [JsonProperty("vpc_config_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcConfigInfo> VpcConfigInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkConfig {\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  managementSubnetCidr: ").Append(ManagementSubnetCidr).Append("\n");
            sb.Append("  managementNodeSubnetId: ").Append(ManagementNodeSubnetId).Append("\n");
            sb.Append("  vpcConfigInfos: ").Append(VpcConfigInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkConfig input)
        {
            if (input == null) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.ManagementSubnetCidr != input.ManagementSubnetCidr || (this.ManagementSubnetCidr != null && !this.ManagementSubnetCidr.Equals(input.ManagementSubnetCidr))) return false;
            if (this.ManagementNodeSubnetId != input.ManagementNodeSubnetId || (this.ManagementNodeSubnetId != null && !this.ManagementNodeSubnetId.Equals(input.ManagementNodeSubnetId))) return false;
            if (this.VpcConfigInfos != input.VpcConfigInfos || (this.VpcConfigInfos != null && input.VpcConfigInfos != null && !this.VpcConfigInfos.SequenceEqual(input.VpcConfigInfos))) return false;

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
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.ManagementSubnetCidr != null) hashCode = hashCode * 59 + this.ManagementSubnetCidr.GetHashCode();
                if (this.ManagementNodeSubnetId != null) hashCode = hashCode * 59 + this.ManagementNodeSubnetId.GetHashCode();
                if (this.VpcConfigInfos != null) hashCode = hashCode * 59 + this.VpcConfigInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
