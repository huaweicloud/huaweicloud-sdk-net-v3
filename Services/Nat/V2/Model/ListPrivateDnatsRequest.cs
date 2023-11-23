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
    public class ListPrivateDnatsRequest 
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
        /// DNAT规则的ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 企业项目ID。创建DNAT规则时，关联的企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// DNAT规则的描述。长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 私网NAT网关实例的ID。
        /// </summary>
        [SDKProperty("gateway_id", IsQuery = true)]
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GatewayId { get; set; }

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [SDKProperty("transit_ip_id", IsQuery = true)]
        [JsonProperty("transit_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitIpId { get; set; }

        /// <summary>
        /// 中转IP的地址。
        /// </summary>
        [SDKProperty("external_ip_address", IsQuery = true)]
        [JsonProperty("external_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExternalIpAddress { get; set; }

        /// <summary>
        /// 网络接口ID，支持计算、ELB、VIP等实例的网络接口。
        /// </summary>
        [SDKProperty("network_interface_id", IsQuery = true)]
        [JsonProperty("network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NetworkInterfaceId { get; set; }

        /// <summary>
        /// DNAT规则后端的类型。 取值：     COMPUTE：后端为计算实例。     VIP：后端为VIP的实例。     ELB：后端为ELB的实例。     ELBv3：后端为ELBv3的实例。     CUSTOMIZE：后端为自定义IP。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 后端实例的IP私网地址。
        /// </summary>
        [SDKProperty("private_ip_address", IsQuery = true)]
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIpAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateDnatsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  transitIpId: ").Append(TransitIpId).Append("\n");
            sb.Append("  externalIpAddress: ").Append(ExternalIpAddress).Append("\n");
            sb.Append("  networkInterfaceId: ").Append(NetworkInterfaceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateDnatsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateDnatsRequest input)
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    this.GatewayId != null &&
                    input.GatewayId != null &&
                    this.GatewayId.SequenceEqual(input.GatewayId)
                ) && 
                (
                    this.TransitIpId == input.TransitIpId ||
                    this.TransitIpId != null &&
                    input.TransitIpId != null &&
                    this.TransitIpId.SequenceEqual(input.TransitIpId)
                ) && 
                (
                    this.ExternalIpAddress == input.ExternalIpAddress ||
                    this.ExternalIpAddress != null &&
                    input.ExternalIpAddress != null &&
                    this.ExternalIpAddress.SequenceEqual(input.ExternalIpAddress)
                ) && 
                (
                    this.NetworkInterfaceId == input.NetworkInterfaceId ||
                    this.NetworkInterfaceId != null &&
                    input.NetworkInterfaceId != null &&
                    this.NetworkInterfaceId.SequenceEqual(input.NetworkInterfaceId)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type != null &&
                    input.Type != null &&
                    this.Type.SequenceEqual(input.Type)
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    this.PrivateIpAddress != null &&
                    input.PrivateIpAddress != null &&
                    this.PrivateIpAddress.SequenceEqual(input.PrivateIpAddress)
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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GatewayId != null)
                    hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.TransitIpId != null)
                    hashCode = hashCode * 59 + this.TransitIpId.GetHashCode();
                if (this.ExternalIpAddress != null)
                    hashCode = hashCode * 59 + this.ExternalIpAddress.GetHashCode();
                if (this.NetworkInterfaceId != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
