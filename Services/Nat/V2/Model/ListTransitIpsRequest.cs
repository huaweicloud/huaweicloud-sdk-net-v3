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
    /// Request Object
    /// </summary>
    public class ListTransitIpsRequest 
    {

        /// <summary>
        /// 功能说明：每页返回的个数。 取值范围：0~2000。 默认值：2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 功能说明：分页查询起始的资源ID，为空时查询第一页。 值从上一次查询的PageInfo中的next_marker或者previous_marker中获取。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 是否查询前一页。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 中转IP的网络接口ID。
        /// </summary>
        [SDKProperty("network_interface_id", IsQuery = true)]
        [JsonProperty("network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NetworkInterfaceId { get; set; }

        /// <summary>
        /// 中转IP地址。
        /// </summary>
        [SDKProperty("ip_address", IsQuery = true)]
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// 中转IP绑定的私网NAT网关实例的ID。
        /// </summary>
        [SDKProperty("gateway_id", IsQuery = true)]
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GatewayId { get; set; }

        /// <summary>
        /// 企业项目ID。创建中转IP时，关联的企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 当前租户子网的ID。
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransitIpsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  networkInterfaceId: ").Append(NetworkInterfaceId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransitIpsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransitIpsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.NetworkInterfaceId == input.NetworkInterfaceId ||
                    this.NetworkInterfaceId != null &&
                    input.NetworkInterfaceId != null &&
                    this.NetworkInterfaceId.SequenceEqual(input.NetworkInterfaceId)
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    this.IpAddress != null &&
                    input.IpAddress != null &&
                    this.IpAddress.SequenceEqual(input.IpAddress)
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    this.GatewayId != null &&
                    input.GatewayId != null &&
                    this.GatewayId.SequenceEqual(input.GatewayId)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.VirsubnetId == input.VirsubnetId ||
                    this.VirsubnetId != null &&
                    input.VirsubnetId != null &&
                    this.VirsubnetId.SequenceEqual(input.VirsubnetId)
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NetworkInterfaceId != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.GatewayId != null)
                    hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.VirsubnetId != null)
                    hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
