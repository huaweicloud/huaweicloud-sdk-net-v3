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
    public class CreatePrivateSnatOption 
    {

        /// <summary>
        /// 私网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayId { get; set; }

        /// <summary>
        /// 功能说明：规则匹配的CIDR。取值约束：与virsubnet_id参数二选一。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 功能说明：规则匹配的子网的ID。 取值约束：与cidr参数二选一。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        /// <summary>
        /// SNAT规则的描述。长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：中转IP的ID的列表。 取值约束：中转IP的ID个数不能超过1个。
        /// </summary>
        [JsonProperty("transit_ip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitIpIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateSnatOption {\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  transitIpIds: ").Append(TransitIpIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateSnatOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateSnatOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.VirsubnetId == input.VirsubnetId ||
                    (this.VirsubnetId != null &&
                    this.VirsubnetId.Equals(input.VirsubnetId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TransitIpIds == input.TransitIpIds ||
                    this.TransitIpIds != null &&
                    input.TransitIpIds != null &&
                    this.TransitIpIds.SequenceEqual(input.TransitIpIds)
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
                if (this.GatewayId != null)
                    hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.VirsubnetId != null)
                    hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TransitIpIds != null)
                    hashCode = hashCode * 59 + this.TransitIpIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
