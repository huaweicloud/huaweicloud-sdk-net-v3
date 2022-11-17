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
    /// 创建SNAT规则的请求体。
    /// </summary>
    public class CreateNatGatewaySnatRuleOption 
    {

        /// <summary>
        /// 公网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// cidr，可以是网段或者主机格式，与network_id参数二选一。 Source_type&#x3D;0时，cidr必须是vpc 子网网段的子集(不能相等）; Source_type&#x3D;1时，cidr必须指定专线侧网段。 
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 规则使用的网络id。与cidr参数二选一。
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// SNAT规则的描述，长度限制为255。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 0：VPC侧，可以指定network_id 或者cidr 1：专线侧，只能指定cidr 不输入默认为0（VPC） 
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP的id，多个弹性公网IP使用逗号分隔。 取值范围：最大长度4096字节。 约束：弹性公网IP的id个数不能超过20个。 
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNatGatewaySnatRuleOption {\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNatGatewaySnatRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNatGatewaySnatRuleOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NatGatewayId == input.NatGatewayId ||
                    (this.NatGatewayId != null &&
                    this.NatGatewayId.Equals(input.NatGatewayId))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.FloatingIpId == input.FloatingIpId ||
                    (this.FloatingIpId != null &&
                    this.FloatingIpId.Equals(input.FloatingIpId))
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
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.FloatingIpId != null)
                    hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
