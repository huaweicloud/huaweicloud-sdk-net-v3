using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 创建虚拟IGW的请求体
    /// </summary>
    public class CreateTenantVpcIgwRequestBodyVpcIgw 
    {

        /// <summary>
        /// vpcid
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 创建VPC IGW的network id
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 是否添加默认路由
        /// </summary>
        [JsonProperty("add_route", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddRoute { get; set; }

        /// <summary>
        /// 是否使能ipv6
        /// </summary>
        [JsonProperty("enable_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// 虚拟IGW的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTenantVpcIgwRequestBodyVpcIgw {\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  addRoute: ").Append(AddRoute).Append("\n");
            sb.Append("  enableIpv6: ").Append(EnableIpv6).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTenantVpcIgwRequestBodyVpcIgw);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTenantVpcIgwRequestBodyVpcIgw input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.AddRoute == input.AddRoute ||
                    (this.AddRoute != null &&
                    this.AddRoute.Equals(input.AddRoute))
                ) && 
                (
                    this.EnableIpv6 == input.EnableIpv6 ||
                    (this.EnableIpv6 != null &&
                    this.EnableIpv6.Equals(input.EnableIpv6))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.AddRoute != null)
                    hashCode = hashCode * 59 + this.AddRoute.GetHashCode();
                if (this.EnableIpv6 != null)
                    hashCode = hashCode * 59 + this.EnableIpv6.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
