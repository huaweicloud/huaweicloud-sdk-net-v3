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
    /// VPC配置信息。
    /// </summary>
    public class VpcConfigInfo 
    {

        /// <summary>
        /// 已使用的子网信息。
        /// </summary>
        [JsonProperty("used_subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UsedSubnetIds { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网ID列表。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 是否为默认接入VPC。
        /// </summary>
        [JsonProperty("default_access_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAccessVpc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpcConfigInfo {\n");
            sb.Append("  usedSubnetIds: ").Append(UsedSubnetIds).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  defaultAccessVpc: ").Append(DefaultAccessVpc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VpcConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VpcConfigInfo input)
        {
            if (input == null) return false;
            if (this.UsedSubnetIds != input.UsedSubnetIds || (this.UsedSubnetIds != null && input.UsedSubnetIds != null && !this.UsedSubnetIds.SequenceEqual(input.UsedSubnetIds))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.DefaultAccessVpc != input.DefaultAccessVpc || (this.DefaultAccessVpc != null && !this.DefaultAccessVpc.Equals(input.DefaultAccessVpc))) return false;

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
                if (this.UsedSubnetIds != null) hashCode = hashCode * 59 + this.UsedSubnetIds.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.DefaultAccessVpc != null) hashCode = hashCode * 59 + this.DefaultAccessVpc.GetHashCode();
                return hashCode;
            }
        }
    }
}
