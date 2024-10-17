using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 主网卡的描述信息。 
    /// </summary>
    public class NicSpec 
    {

        /// <summary>
        /// 网卡所在子网的网络ID。主网卡创建时若未指定subnetId,将使用集群子网。若节点池同时配置了subnetList，则节点池扩容子网以subnetList字段为准。扩展网卡创建时必须指定subnetId。  
        /// </summary>
        [JsonProperty("subnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 主网卡的IP将通过fixedIps指定，数量不得大于创建的节点数。fixedIps或ipBlock同时只能指定一个。扩展网卡不支持指定fiexdIps。
        /// </summary>
        [JsonProperty("fixedIps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FixedIps { get; set; }

        /// <summary>
        /// 主网卡的IP段的CIDR格式，创建的节点IP将属于该IP段内。fixedIps或ipBlock同时只能指定一个。
        /// </summary>
        [JsonProperty("ipBlock", NullValueHandling = NullValueHandling.Ignore)]
        public string IpBlock { get; set; }

        /// <summary>
        /// 网卡所在子网的网络ID列表，支持节点池配置多个子网，最多支持配置20个子网。
        /// </summary>
        [JsonProperty("subnetList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NicSpec {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  fixedIps: ").Append(FixedIps).Append("\n");
            sb.Append("  ipBlock: ").Append(IpBlock).Append("\n");
            sb.Append("  subnetList: ").Append(SubnetList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NicSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NicSpec input)
        {
            if (input == null) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.FixedIps != input.FixedIps || (this.FixedIps != null && input.FixedIps != null && !this.FixedIps.SequenceEqual(input.FixedIps))) return false;
            if (this.IpBlock != input.IpBlock || (this.IpBlock != null && !this.IpBlock.Equals(input.IpBlock))) return false;
            if (this.SubnetList != input.SubnetList || (this.SubnetList != null && input.SubnetList != null && !this.SubnetList.SequenceEqual(input.SubnetList))) return false;

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
                if (this.FixedIps != null) hashCode = hashCode * 59 + this.FixedIps.GetHashCode();
                if (this.IpBlock != null) hashCode = hashCode * 59 + this.IpBlock.GetHashCode();
                if (this.SubnetList != null) hashCode = hashCode * 59 + this.SubnetList.GetHashCode();
                return hashCode;
            }
        }
    }
}
